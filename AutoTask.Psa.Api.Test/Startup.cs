namespace AutoTask.Psa.Api.Test;

public static class Startup
{
	public static void ConfigureHost(IHostBuilder hostBuilder)
	{
		var a = Directory.GetCurrentDirectory();
		var fileInfo = new FileInfo(Path.Combine(a, "../../../appsettings.json"));
		hostBuilder
			.ConfigureHostConfiguration(builder => builder.AddJsonFile(fileInfo.FullName));
	}

	public static void ConfigureServices(
		IServiceCollection services,
		HostBuilderContext context)
	{
		var configurationSection = context.Configuration.GetSection("AppSettings");
		services
			.Configure<AppSettings>(configurationSection);
	}
}
