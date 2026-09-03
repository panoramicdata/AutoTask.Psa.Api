namespace AutoTask.Psa.Api;

/// <summary>
/// An <see cref="HttpClientHandler"/> that injects AutoTask authentication headers into every outgoing request.
/// </summary>
public class AuthenticatedHttpClientHandler : HttpClientHandler
{
	private readonly AutoTaskClientOptions _options;

	private readonly ILogger _logger;

	/// <summary>
	/// Initialises a new instance of <see cref="AuthenticatedHttpClientHandler"/>.
	/// </summary>
	/// <param name="options">The client options containing credentials and configuration.</param>
	/// <param name="logger">The logger to use for request/response diagnostics.</param>
	public AuthenticatedHttpClientHandler(
		AutoTaskClientOptions options,
		ILogger logger)
	{
		options.Validate();
		_options = options;
		_logger = logger;
	}

	/// <summary>
	/// Adds AutoTask authentication headers then forwards the request to the inner handler.
	/// </summary>
	/// <param name="request">The HTTP request message to send.</param>
	/// <param name="cancellationToken">A cancellation token to cancel the operation.</param>
	/// <returns>The HTTP response message.</returns>
	protected override async Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		AddAuthenticationHeaders(request);

		// Get a GUID to uniquely identify the request
		var guid = Guid.NewGuid();
		await LogRequestAsync(guid, request, cancellationToken).ConfigureAwait(false);

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

		await LogResponseAsync(guid, request, response, cancellationToken).ConfigureAwait(false);

		return response;
	}

	/// <summary>
	/// Adds the AutoTask authentication headers to <paramref name="request"/>, leaving any that the
	/// caller has already set in place.
	/// </summary>
	/// <param name="request">The HTTP request message to add headers to.</param>
	private void AddAuthenticationHeaders(HttpRequestMessage request)
	{
		AddHeaderIfAbsent(request, "ApiIntegrationCode", _options.IntegrationCode);
		AddHeaderIfAbsent(request, "UserName", _options.UserName);
		AddHeaderIfAbsent(request, "Secret", _options.Password);
		AddHeaderIfAbsent(request, "UserAgent", "AutoTask.Psa.Api.AutoTaskClient");
	}

	/// <summary>
	/// Adds <paramref name="name"/> to <paramref name="request"/> unless it is already present.
	/// </summary>
	private static void AddHeaderIfAbsent(HttpRequestMessage request, string name, string? value)
	{
		if (!request.Headers.TryGetValues(name, out _))
		{
			request.Headers.Add(name, value);
		}
	}

	/// <summary>
	/// Logs an outgoing request at Debug level, with sensitive headers redacted.
	/// </summary>
	private async Task LogRequestAsync(
		Guid guid,
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(LogLevel.Debug))
		{
			return;
		}

		_logger.LogDebug("{Guid}:{RequestMethod}:{RequestUri}\nHeaders:{Headers}\nBody:{Body}",
			guid.ToString(),
			request.Method,
			request.RequestUri,
			request.Headers.ToDebugString(),
			request.Content is null ? null : await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false)
			);
	}

	/// <summary>
	/// Logs a response at Debug level.
	/// </summary>
	private async Task LogResponseAsync(
		Guid guid,
		HttpRequestMessage request,
		HttpResponseMessage response,
		CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(LogLevel.Debug))
		{
			return;
		}

		_logger.LogDebug("{Guid}:{ResponseStatusCode}:{Body}",
			guid.ToString(),
			response.StatusCode,
			request.Content is null ? null : await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false));
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
