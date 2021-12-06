using System.Threading.Tasks;

namespace AutoTask.Psa.Api.Test;

public class TicketTests : TestBase
{
	public TicketTests(
		ITestOutputHelper testOutputHelper,
		IOptions<AppSettings> options) : base(testOutputHelper, options)
	{
	}

	[Fact]
	public async Task QueryAsync_WithString_Succeeds()
	{
		var response = await AutoTaskClient
			.Tickets
			.QueryAsync("{\"filter\": [ {\"field\": \"createDate\", \"op\": \"gte\", \"value\": \"2021-09-01\"}]}")
			.ConfigureAwait(false);

		response.Should().NotBeNull(because: "a valid request should return a response object");
		response.Items.Should().NotBeEmpty(because: "there should be at least one ticket created in the last 24 hours");
	}
}
