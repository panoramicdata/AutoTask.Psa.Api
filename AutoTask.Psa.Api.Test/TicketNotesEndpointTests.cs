using System.Net;
using System.Net.Http;

namespace AutoTask.Psa.Api.Test;

/// <summary>
/// Tests that TicketNotes exposes the create and update endpoints AutoTask supports (issue #1).
///
/// <para>
/// The flat TicketNotes collection was query-only, so a note could only be written through the
/// child route under a ticket. AutoTask documents the entity as Can Create and Can Update, and the
/// sibling TaskNotes has carried POST, PATCH and PUT all along.
/// </para>
/// </summary>
public class TicketNotesEndpointTests
{
	private sealed class RecordingHandler : HttpMessageHandler
	{
		public List<(HttpMethod Method, string Url)> Requests { get; } = [];

		protected override Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();

			Requests.Add((request.Method, request.RequestUri!.AbsolutePath));

			return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
			{
				Content = new StringContent("""{"id":1}"""),
				RequestMessage = request
			});
		}
	}

	private static AutoTaskClient CreateClient(RecordingHandler handler)
		=> new(new HttpClient(handler) { BaseAddress = new Uri("https://example.invalid/atservicesrest/") });

	[Fact]
	public async Task CreateAsync_PostsToTheTicketNotesCollection()
	{
		using var handler = new RecordingHandler();
		using var client = CreateClient(handler);

		await client.TicketNotes.CreateAsync(new TicketNoteModel(), TestContext.Current.CancellationToken);

		handler.Requests.Should().Equal((HttpMethod.Post, "/atservicesrest/V1.0/TicketNotes"));
	}

	[Fact]
	public async Task PatchAsync_PatchesTheTicketNotesCollection()
	{
		using var handler = new RecordingHandler();
		using var client = CreateClient(handler);

		await client.TicketNotes.PatchAsync(new TicketNoteModel(), TestContext.Current.CancellationToken);

		handler.Requests.Should().Equal((HttpMethod.Patch, "/atservicesrest/V1.0/TicketNotes"));
	}

	[Fact]
	public async Task UpdateAsync_PutsToTheTicketNotesCollection()
	{
		using var handler = new RecordingHandler();
		using var client = CreateClient(handler);

		await client.TicketNotes.UpdateAsync(new TicketNoteModel(), TestContext.Current.CancellationToken);

		handler.Requests.Should().Equal((HttpMethod.Put, "/atservicesrest/V1.0/TicketNotes"));
	}

	/// <summary>
	/// AutoTask documents TicketNotes as Can Create and Can Update but not Can Delete, so the
	/// absence of a delete method on the flat collection is deliberate.
	/// </summary>
	[Fact]
	public void ITicketNotes_ExposesNoDeleteMethod()
		=> typeof(Interfaces.ITicketNotes)
			.GetMethods()
			.Should()
			.NotContain(method => method.Name.Contains("Delete", StringComparison.Ordinal));
}
