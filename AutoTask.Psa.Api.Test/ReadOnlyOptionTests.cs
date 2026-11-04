using Microsoft.Extensions.Logging.Abstractions;
using System.Net.Http;

namespace AutoTask.Psa.Api.Test;

/// <summary>Pure unit tests: a refused write throws before any request is sent, so no credentials or server are needed.</summary>
public class ReadOnlyOptionTests
{
	private static AutoTaskClientOptions NewOptions(bool isReadOnly) => new()
	{
		ServerId = 1,
		UserName = "fake-user",
		Password = "fake-password",
		IntegrationCode = "fake-code",
		IsReadOnly = isReadOnly
	};

	/// <summary>Verifies the default.</summary>
	[Fact]
	public void IsReadOnly_DefaultsToFalse()
		=> new AutoTaskClientOptions().IsReadOnly.Should().BeFalse();

	/// <summary>Verifies a write is refused end to end through the real handler.</summary>
	[Fact]
	public async Task DeleteIsRefused_WhenIsReadOnly()
	{
		using var client = new AutoTaskClient(NewOptions(true), NullLogger.Instance);

		var act = () => client.DeleteAsync("V1.0/Tickets/1", TestContext.Current.CancellationToken);

		await act.Should().ThrowAsync<InvalidOperationException>();
	}

	/// <summary>Verifies the allow-list: reads and the query POSTs pass, other writes do not.</summary>
	[Theory]
	[InlineData("GET", "https://x.autotask.net/atservicesrest/V1.0/Tickets/1", true)]
	[InlineData("POST", "https://x.autotask.net/atservicesrest/V1.0/Tickets/query", true)]
	[InlineData("POST", "https://x.autotask.net/atservicesrest/V1.0/Tickets/query/count", true)]
	[InlineData("POST", "https://x.autotask.net/atservicesrest/V1.0/Tickets", false)]
	[InlineData("PATCH", "https://x.autotask.net/atservicesrest/V1.0/Tickets", false)]
	[InlineData("PUT", "https://x.autotask.net/atservicesrest/V1.0/Tickets", false)]
	[InlineData("DELETE", "https://x.autotask.net/atservicesrest/V1.0/Tickets/1", false)]
	public void IsReadRequest_ClassifiesRequests(string method, string url, bool expected)
	{
		using var request = new HttpRequestMessage(new HttpMethod(method), url);

		AuthenticatedHttpClientHandler.IsReadRequest(request).Should().Be(expected);
	}
}
