namespace AutoTask.Psa.Api.Test;

public class TestBase
{
	public ICacheLogger<TestBase> Log { get; }

	public AutoTaskClient AutoTaskClient { get; }

	public TestBase(
		ITestOutputHelper testOutputHelper,
		IOptions<AppSettings> options)
	{
		Log = testOutputHelper.BuildLoggerFor<TestBase>(LogLevel.Debug);
		var optionsValue = options.Value;
		AutoTaskClient = new AutoTaskClient(new AutoTaskClientOptions
		{
			ServerId = optionsValue.ServerId,
			UserName = optionsValue.Username,
			Password = optionsValue.Password,
			IntegrationCode = optionsValue.IntegrationCode
		},
			Log
		);
	}
}
