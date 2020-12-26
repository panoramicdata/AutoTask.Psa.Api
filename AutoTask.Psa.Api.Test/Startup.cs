using AutoTask.Psa.Api.Test.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace AutoTask.Psa.Api.Test
{
	public class Startup
	{
		public void ConfigureHost(IHostBuilder hostBuilder)
		{
			var a = Directory.GetCurrentDirectory();
			var fileInfo = new FileInfo(Path.Combine(a, "../../../appsettings.json"));
			hostBuilder
				.ConfigureHostConfiguration(builder => builder.AddJsonFile(fileInfo.FullName));
		}

		public void ConfigureServices(
			IServiceCollection services,
			HostBuilderContext context)
		{
			var configurationSection = context.Configuration.GetSection("AppSettings");
			services
				.Configure<AppSettings>(configurationSection);
		}
	}
}
