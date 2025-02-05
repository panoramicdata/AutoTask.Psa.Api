namespace AutoTask.Psa.Api.Test;

public class TicketTests(
	ITestOutputHelper testOutputHelper,
	Fixture fixture) : TestBase(testOutputHelper, fixture)
{
	[Fact]
	public async Task QueryAsync_WithString_Succeeds()
	{
		var response = await AutoTaskClient
			.Tickets
			.QueryAsync("{\"filter\": [ {\"field\": \"createDate\", \"op\": \"gte\", \"value\": \"2021-09-01\"}]}")
			;

		response.Should().NotBeNull(because: "a valid request should return a response object");
		response.Items.Should().NotBeEmpty(because: "there should be at least one ticket created in the last 24 hours");
	}
}
