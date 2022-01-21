namespace AutoTask.Psa.Api.Test;

public class GetJObjectTests : TestBase
{
	public GetJObjectTests(
		ITestOutputHelper testOutputHelper,
		IOptions<AppSettings> options) : base(testOutputHelper, options)
	{
	}

	[Fact]
	public async void QueryAsync_WithString_Succeeds()
	{
		var response = await AutoTaskClient
			.GetJObjectAsync("V1.0/Products/entityInformation", CancellationToken.None)
			.ConfigureAwait(false);

		response.Should().NotBeNull(because: "a valid request should return a response object");
	}
}
