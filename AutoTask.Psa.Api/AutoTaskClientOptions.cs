namespace AutoTask.Psa.Api;

/// <summary>
/// Configuration options for <see cref="AutoTaskClient"/>.
/// </summary>
public class AutoTaskClientOptions
{
	/// <summary>Gets or sets the AutoTask server ID used to construct the base URL.</summary>
	public int? ServerId { get; set; }

	/// <summary>Gets or sets the API user name.</summary>
	public string? UserName { get; set; }

	/// <summary>Gets or sets the API secret (password).</summary>
	public string? Password { get; set; }

	/// <summary>Gets or sets the AutoTask integration code.</summary>
	public string? IntegrationCode { get; set; }

	/// <summary>Gets or sets a value indicating whether exception response content is written to the log.</summary>
	public bool LogExceptionContent { get; set; }

	/// <summary>
	/// Validates that all required options are set, throwing a <see cref="ValidationException"/> if any are missing.
	/// </summary>
	public void Validate()
	{
		if (ServerId is null)
		{
			throw new ValidationException($"{nameof(ServerId)} missing.");
		}
		if (UserName is null)
		{
			throw new ValidationException($"{nameof(UserName)} missing.");
		}
		if (Password is null)
		{
			throw new ValidationException($"{nameof(Password)} missing.");
		}
		if (IntegrationCode is null)
		{
			throw new ValidationException($"{nameof(IntegrationCode)} missing.");
		}
	}
}
