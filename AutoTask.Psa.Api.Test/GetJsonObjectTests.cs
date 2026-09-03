namespace AutoTask.Psa.Api.Test;

public class GetJsonObjectTests(
	ITestOutputHelper testOutputHelper,
	Fixture fixture) : TestBase(testOutputHelper, fixture)
{
	[Fact]
	public async Task QueryAsync_WithString_Succeeds()
	{
		var response = await AutoTaskClient
			.GetJsonObjectAsync("V1.0/Products/entityInformation", CancellationToken);

		response.Should().NotBeNull(because: "a valid request should return a response object");
	}
}
