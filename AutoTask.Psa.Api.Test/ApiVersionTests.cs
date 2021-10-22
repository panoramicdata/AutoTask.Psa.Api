using AutoTask.Psa.Api.Test.Config;
using FluentAssertions;
using Microsoft.Extensions.Options;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace AutoTask.Psa.Api.Test
{
	public class ApiVersionTests : TestBase
	{
		public ApiVersionTests(
			ITestOutputHelper testOutputHelper,
			IOptions<AppSettings> options
			) : base(testOutputHelper, options)
		{
		}

		[Fact]
		public async void GetAsync_Succeeds()
		{
			var apiVersionResponseModel = await AutoTaskClient
				.ApiVersions
				.GetAsync(CancellationToken.None)
				.ConfigureAwait(false);

			apiVersionResponseModel.Should().NotBeNull(because: "a valid request should return a response object");
			apiVersionResponseModel.ApiVersions.Should().NotBeEmpty(because: "there should be at least one API version in any system");
		}
	}
}
