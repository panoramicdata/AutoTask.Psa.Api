namespace AutoTask.Psa.Api.Test;

public class ApiVersionTests(
	ITestOutputHelper testOutputHelper,
	Fixture fixture
		) : TestBase(testOutputHelper, fixture)
{
	[Fact]
	public async Task GetAsync_Succeeds()
	{
		var apiVersionResponseModel = await AutoTaskClient
			.ApiVersions
			.GetAsync(CancellationToken);

		apiVersionResponseModel.Should().NotBeNull(because: "a valid request should return a response object");
		apiVersionResponseModel.ApiVersions.Should().NotBeEmpty(because: "there should be at least one API version in any system");
	}
}
