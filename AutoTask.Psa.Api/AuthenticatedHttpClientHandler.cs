namespace AutoTask.Psa.Api;

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
		if (!request.Headers.TryGetValues("UserAgent", out _))
		{
			request.Headers.Add("UserAgent", "AutoTask.Psa.Api.AutoTaskClient");
		}

		// Get a GUID to uniquely identify the request
		var guid = Guid.NewGuid();
		_logger.LogDebug("{Guid}:{RequestMethod}:{RequestUri}\nHeaders:{Headers}\nBody:{Body}",
			guid.ToString(),
			request.Method,
			request.RequestUri,
			request.Headers,
			request.Content is null ? null : await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false)
			);

		HttpResponseMessage response;
		try
		{
			response = await base
				.SendAsync(request, cancellationToken)
				.ConfigureAwait(false);
		}
		catch (ApiException ex)
		{
			LogApiException(ex);
			throw;
		}

		_logger.LogDebug("{Guid}:{ResponseStatusCode}:{Body}",
			guid.ToString(),
			response.StatusCode,
			request.Content is null ? null : await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false));

		return response;
	}

	/// <summary>
	/// Log details of an ApiException (as enabled in options)
	/// </summary>
	/// <param name="ex">The exception whose details are to be logged</param>
	private void LogApiException(ApiException ex)
	{
		if (ex.Content is null)
		{
			return;
		}

		try
		{
			if (_options.LogExceptionContent)
			{
				_logger.LogError(ex, "Error from Refit; response content is: {Content}", ex.Content);
			}
		}
		catch (Exception)
		{
			// Nothing we can do about a logging exception; suppress it!
		}
	}
}
