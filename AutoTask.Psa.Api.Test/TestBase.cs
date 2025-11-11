using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace AutoTask.Psa.Api.Test;

[CollectionDefinition("Dependency Injection")]
public class TestBase : TestBed<Fixture>
{
	public AutoTaskClient AutoTaskClient { get; }

	public ILogger Log { get; }

	protected static CancellationToken CancellationToken => TestContext.Current.CancellationToken;

	public TestBase(
		ITestOutputHelper testOutputHelper,
		Fixture fixture) : base(testOutputHelper, fixture)
	{
		ArgumentNullException.ThrowIfNull(testOutputHelper);
		ArgumentNullException.ThrowIfNull(fixture);

		// Logger
		var loggerFactory = fixture
			.GetService<ILoggerFactory>(testOutputHelper)
			?? throw new InvalidOperationException("LoggerFactory is null");
		Log = loggerFactory.CreateLogger(GetType());

		var options = fixture.GetService<IOptions<AppSettings>>(testOutputHelper)
			?? throw new InvalidOperationException("Missing options");
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
