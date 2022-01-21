using System.Threading.Tasks;

namespace AutoTask.Psa.Api.Test;

public class TaskTests : TestBase
{
	public TaskTests(
		ITestOutputHelper testOutputHelper,
		IOptions<AppSettings> options
		) : base(testOutputHelper, options)
	{
	}

	[Fact]
	public async Task QueryAsync_Succeeds()
	{
		var queryModel = new QueryModel
		{
			MaxRecords = 10,
			Filter = new List<Filter>
				{
					new Filter
					{
						Field = "id",
						Op = "gt",
						Value = 0
					}
				}
		};
		var response = await AutoTaskClient
			.Tasks
			.QueryAsync(queryModel)
			.ConfigureAwait(false);

		response.Should().NotBeNull(because: "a valid request should return a response object");
		response.Items.Should().NotBeEmpty(because: "there should be at least one task in any system");
	}
}
