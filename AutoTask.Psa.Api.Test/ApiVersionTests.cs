using System.Threading.Tasks;

namespace AutoTask.Psa.Api.Test;

public class ApiVersionTests : TestBase
{
	public ApiVersionTests(
		ITestOutputHelper testOutputHelper,
		IOptions<AppSettings> options
		) : base(testOutputHelper, options)
	{
	}

	[Fact]
	public async Task GetAsync_Succeeds()
	{
		var apiVersionResponseModel = await AutoTaskClient
			.ApiVersions
			.GetAsync(CancellationToken.None)
			.ConfigureAwait(false);

		apiVersionResponseModel.Should().NotBeNull(because: "a valid request should return a response object");
		apiVersionResponseModel.ApiVersions.Should().NotBeEmpty(because: "there should be at least one API version in any system");
	}
}
