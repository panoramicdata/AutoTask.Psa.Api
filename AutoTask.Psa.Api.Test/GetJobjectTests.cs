namespace AutoTask.Psa.Api.Test;

public class GetJObjectTests(
	ITestOutputHelper testOutputHelper,
	Fixture fixture) : TestBase(testOutputHelper, fixture)
{
	[Fact]
	public async Task QueryAsync_WithString_Succeeds()
	{
		var response = await AutoTaskClient
			.GetJObjectAsync("V1.0/Products/entityInformation", CancellationToken.None);

		response.Should().NotBeNull(because: "a valid request should return a response object");
	}
}
