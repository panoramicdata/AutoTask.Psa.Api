namespace AutoTask.Psa.Api.Test;

public class GetJObjectTests(
	ITestOutputHelper testOutputHelper,
	IOptions<AppSettings> options) : TestBase(testOutputHelper, options)
{
	[Fact]
	public async Task QueryAsync_WithString_Succeeds()
	{
		var response = await AutoTaskClient
			.GetJObjectAsync("V1.0/Products/entityInformation", CancellationToken.None)
			.ConfigureAwait(false);

		response.Should().NotBeNull(because: "a valid request should return a response object");
	}
}
