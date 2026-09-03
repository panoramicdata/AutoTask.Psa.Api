using Refit;
using System.Net;
using System.Net.Http;
using System.Text.Json.Nodes;

namespace AutoTask.Psa.Api.Test;

/// <summary>
/// Tests for the raw-JSON query helpers on <see cref="AutoTaskClient"/>.
///
/// <para>
/// These helpers used to hand their response bodies to Newtonsoft's <c>JObject</c>. They now use
/// <c>System.Text.Json</c>, whose null handling and node model differ, so the paging contract is
/// pinned here rather than left to the integration tests: those need live AutoTask credentials and
/// will not run on a build agent.
/// </para>
/// </summary>
public class JsonObjectQueryTests
{
	/// <summary>
	/// Serves a canned response per request, and records the URLs it was asked for.
	/// </summary>
	private sealed class StubHandler(params string[] responseBodies) : HttpMessageHandler
	{
		private int _callCount;

		public List<string> RequestedUrls { get; } = [];

		public List<HttpMethod> RequestedMethods { get; } = [];

		public List<string?> RequestedBodies { get; } = [];

		public HttpStatusCode StatusCode { get; init; } = HttpStatusCode.OK;

		protected override Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			RequestedUrls.Add(request.RequestUri!.ToString());
			RequestedMethods.Add(request.Method);
			RequestedBodies.Add(request.Content?.ReadAsStringAsync(cancellationToken).Result);

			var body = responseBodies[Math.Min(_callCount++, responseBodies.Length - 1)];

			return Task.FromResult(new HttpResponseMessage(StatusCode)
			{
				Content = new StringContent(body),
				RequestMessage = request
			});
		}
	}

	private static AutoTaskClient CreateClient(StubHandler handler)
		=> new(new HttpClient(handler) { BaseAddress = new Uri("https://example.invalid/") });

	[Fact]
	public async Task GetJsonObjectAsync_ObjectBody_IsDeserialised()
	{
		using var handler = new StubHandler("""{"fields":[{"name":"id"}]}""");
		using var client = CreateClient(handler);

		var result = await client.GetJsonObjectAsync("V1.0/Products/entityInformation", TestContext.Current.CancellationToken);

		result.Should().NotBeNull();
		result!["fields"]!.AsArray().Should().HaveCount(1);
	}

	[Fact]
	public async Task GetJsonObjectAsync_EmptyBody_IsNull()
	{
		using var handler = new StubHandler("");
		using var client = CreateClient(handler);

		var result = await client.GetJsonObjectAsync("V1.0/Anything", TestContext.Current.CancellationToken);

		result.Should().BeNull(because: "an empty body has nothing to deserialise");
	}

	[Fact]
	public async Task GetJsonObjectAsync_ErrorStatus_ThrowsApiException()
	{
		using var handler = new StubHandler("""{"errors":["nope"]}""") { StatusCode = HttpStatusCode.BadRequest };
		using var client = CreateClient(handler);

		var act = async () => await client.GetJsonObjectAsync("V1.0/Anything", TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<ApiException>();
	}

	[Fact]
	public async Task GetAllAsync_SinglePage_ReturnsItems()
	{
		using var handler = new StubHandler("""{"items":[{"id":1},{"id":2}],"pageDetails":{"nextPageUrl":null}}""");
		using var client = CreateClient(handler);

		var result = await client.GetAllAsync("V1.0/Tickets/query", TestContext.Current.CancellationToken);

		result.Should().HaveCount(2);
		result[0]["id"]!.GetValue<int>().Should().Be(1);
		handler.RequestedUrls.Should().HaveCount(1, because: "a null nextPageUrl ends the walk");
	}

	[Fact]
	public async Task GetAllAsync_MultiplePages_FollowsNextPageUrlAndConcatenates()
	{
		using var handler = new StubHandler(
			"""{"items":[{"id":1}],"pageDetails":{"nextPageUrl":"https://example.invalid/V1.0/Tickets/query?page=2"}}""",
			"""{"items":[{"id":2}],"pageDetails":{"nextPageUrl":"https://example.invalid/V1.0/Tickets/query?page=3"}}""",
			"""{"items":[{"id":3}],"pageDetails":{"nextPageUrl":""}}""");
		using var client = CreateClient(handler);

		var result = await client.GetAllAsync("V1.0/Tickets/query", TestContext.Current.CancellationToken);

		result.Select(item => item["id"]!.GetValue<int>()).Should().Equal(1, 2, 3);
		handler.RequestedUrls.Should().Equal(
			"https://example.invalid/V1.0/Tickets/query",
			"https://example.invalid/V1.0/Tickets/query?page=2",
			"https://example.invalid/V1.0/Tickets/query?page=3");
	}

	[Fact]
	public async Task GetAllAsync_MissingPageDetails_StopsAfterOnePage()
	{
		using var handler = new StubHandler("""{"items":[{"id":1}]}""");
		using var client = CreateClient(handler);

		var result = await client.GetAllAsync("V1.0/Tickets/query", TestContext.Current.CancellationToken);

		result.Should().HaveCount(1);
		handler.RequestedUrls.Should().HaveCount(1);
	}

	[Fact]
	public async Task GetAllAsync_EmptyItemsArray_ReturnsEmptyList()
	{
		using var handler = new StubHandler("""{"items":[],"pageDetails":{"nextPageUrl":null}}""");
		using var client = CreateClient(handler);

		var result = await client.GetAllAsync("V1.0/Tickets/query", TestContext.Current.CancellationToken);

		result.Should().BeEmpty();
	}

	[Fact]
	public async Task GetAllAsync_NoItemsProperty_ThrowsFormatException()
	{
		using var handler = new StubHandler("""{"pageDetails":{"nextPageUrl":null}}""");
		using var client = CreateClient(handler);

		var act = async () => await client.GetAllAsync("V1.0/Tickets/query", TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<FormatException>();
	}

	[Fact]
	public async Task GetAllAsync_WithBody_PostsThatBody()
	{
		using var handler = new StubHandler("""{"items":[{"id":1}],"pageDetails":{"nextPageUrl":null}}""");
		using var client = CreateClient(handler);

		var result = await client.GetAllAsync("V1.0/Tickets/query", """{"filter":[]}""", TestContext.Current.CancellationToken);

		result.Should().HaveCount(1);
		handler.RequestedMethods.Should().Equal(HttpMethod.Post);
		handler.RequestedBodies.Should().Equal("""{"filter":[]}""");
	}

	[Fact]
	public async Task GetAllAsync_WithoutBody_SendsAGetWithNoContent()
	{
		using var handler = new StubHandler("""{"items":[{"id":1}],"pageDetails":{"nextPageUrl":null}}""");
		using var client = CreateClient(handler);

		_ = await client.GetAllAsync("V1.0/Tickets/query", TestContext.Current.CancellationToken);

		handler.RequestedMethods.Should().Equal(HttpMethod.Get);
		handler.RequestedBodies.Should().Equal([null]);
	}

	[Fact]
	public void EndpointProperty_ReturnsTheSameInstanceEachTime()
	{
		using var handler = new StubHandler("{}");
		using var client = CreateClient(handler);

		client.Tickets.Should().BeSameAs(client.Tickets, because: "endpoints are built once and cached");
	}
}
