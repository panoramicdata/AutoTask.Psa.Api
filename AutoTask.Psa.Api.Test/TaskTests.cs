namespace AutoTask.Psa.Api.Test;

public class TaskTests(
	ITestOutputHelper testOutputHelper,
	Fixture fixture
	) : TestBase(testOutputHelper, fixture)
{
	[Fact]
	public async Task QueryAsync_Succeeds()
	{
		var queryModel = new QueryModel
		{
			MaxRecords = 10,
			Filter =
				[
					new Filter
					{
						Field = "id",
						Op = "gt",
						Value = 0
					}
				]
		};
		var response = await AutoTaskClient
			.Tasks
			.QueryAsync(queryModel)
			;

		response.Should().NotBeNull(because: "a valid request should return a response object");
		response.Items.Should().NotBeEmpty(because: "there should be at least one task in any system");
	}
}
