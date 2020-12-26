using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AutoTask.Psa.Api
{
	public class AuthenticatedHttpClientHandler : HttpClientHandler
	{
		private readonly AutoTaskClientOptions _options;

		private readonly ILogger _logger;

		public AuthenticatedHttpClientHandler(
			AutoTaskClientOptions options,
			ILogger logger)
		{
			options.Validate();
			_options = options;
			_logger = logger;
		}

		protected override async Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			// Set headers
			if (!request.Headers.TryGetValues("ApiIntegrationCode", out _))
			{
				request.Headers.Add("ApiIntegrationCode", _options.IntegrationCode);
			}
			if (!request.Headers.TryGetValues("UserName", out _))
			{
				request.Headers.Add("UserName", _options.UserName);
			}
			if (!request.Headers.TryGetValues("Secret", out _))
			{
				request.Headers.Add("Secret", _options.Password);
			}
			//if (!request.Headers.TryGetValues("Content-Type", out _))
			//{
			//	request.Headers.Add("Content-Type", "application/json");
			//}
			if (!request.Headers.TryGetValues("UserAgent", out _))
			{
				request.Headers.Add("UserAgent", "AutoTask.Psa.Api.AutoTaskClient");
			}

			// Get a GUID to uniquely identify the request
			var guid = Guid.NewGuid();
			_logger.LogDebug($"{guid}:{request.Method}:{request.RequestUri}\nHeaders:{request.Headers}\nBody:{await request.Content.ReadAsStringAsync().ConfigureAwait(false)}");

			var response = await base
				.SendAsync(request, cancellationToken)
				.ConfigureAwait(false);

			_logger.LogDebug($"{guid}:{response.StatusCode}:{await response.Content.ReadAsStringAsync().ConfigureAwait(false)}");

			return response;
		}
	}
}
