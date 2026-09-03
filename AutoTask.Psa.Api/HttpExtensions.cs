using System.Net.Http.Headers;

namespace AutoTask.Psa.Api;

/// <summary>
/// Rendering of HTTP headers for diagnostic output, with credential-bearing values redacted.
/// </summary>
internal static class HttpExtensions
{
	/// <summary>
	/// Header names whose values carry a credential and must never be rendered into a log message or
	/// an exception message.
	/// </summary>
	/// <remarks>
	/// The first three are this API's own authentication scheme, and they are the reason a list copied
	/// from a sibling package would not have fixed this one. AutoTask does not use an Authorization
	/// header at all: it authenticates with three bespoke headers, of which <c>Secret</c> carries the
	/// account password in plain text.
	/// </remarks>
	private static readonly HashSet<string> SensitiveHeaderNames = new(StringComparer.OrdinalIgnoreCase)
	{
		"Secret",
		"UserName",
		"ApiIntegrationCode",
		"Authorization",
		"Proxy-Authorization",
		"Cookie",
		"Set-Cookie",
		"X-API-Key",
		"Api-Key",
		"X-Api-Token",
		"X-Auth-Token",
	};

	/// <summary>
	/// The subset of sensitive headers whose value is of the form "&lt;scheme&gt; &lt;credential&gt;",
	/// where the scheme is safe to keep and useful to see.
	/// </summary>
	private static readonly HashSet<string> SchemePrefixedHeaderNames = new(StringComparer.OrdinalIgnoreCase)
	{
		"Authorization",
		"Proxy-Authorization",
	};

	/// <summary>
	/// Whether a header name denotes a credential-bearing header.
	/// </summary>
	/// <remarks>
	/// The suffix test catches vendor-prefixed variants of the standard header, which an exact-match
	/// list alone would render verbatim.
	/// </remarks>
	private static bool IsSensitive(string name)
		=> SensitiveHeaderNames.Contains(name)
		|| name.EndsWith("Authorization", StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Whether a header's grammar is "&lt;scheme&gt; &lt;credential&gt;", so its scheme can be kept.
	/// </summary>
	private static bool IsSchemePrefixed(string name)
		=> SchemePrefixedHeaderNames.Contains(name)
		|| name.EndsWith("Authorization", StringComparison.OrdinalIgnoreCase);

	/// <summary>
	/// Joins a header's values, replacing the credential with a redaction marker when the header is a
	/// sensitive one.
	/// </summary>
	/// <remarks>
	/// The authentication scheme and the credential length are preserved. That is enough to tell an
	/// engineer that a credential was sent and roughly what shape it had, which is all diagnosis needs,
	/// without writing the credential itself somewhere it will be retained and widely readable.
	/// </remarks>
	internal static string RedactIfSensitive(string name, IEnumerable<string> values)
	{
		var value = string.Join(", ", values);

		if (value.Length == 0 || !IsSensitive(name))
		{
			return value;
		}

		// Only headers whose grammar is "<scheme> <credential>" keep their scheme, so that which
		// authentication mechanism was used remains visible. Applying this to any header containing a
		// space would be unsafe: a cookie such as "session=abc123; HttpOnly" also contains one, and
		// treating the text before it as a scheme would preserve the very value being redacted.
		if (IsSchemePrefixed(name))
		{
			var schemeLength = value.IndexOf(' ', StringComparison.Ordinal);

			if (schemeLength > 0)
			{
				return $"{value[..schemeLength]} <redacted, length {value.Length - schemeLength - 1}>";
			}
		}

		return $"<redacted, length {value.Length}>";
	}

	/// <summary>
	/// Renders headers for diagnostic output, with the value of any credential-bearing header redacted.
	/// </summary>
	/// <remarks>
	/// Passing the header collection itself to a logger renders every value verbatim, because
	/// <c>HttpHeaders.ToString()</c> applies no filtering. This is the safe replacement.
	/// </remarks>
	internal static string ToDebugString(this HttpHeaders headers)
		=> string.Join("\n", headers.Select(h => $"{h.Key}: {RedactIfSensitive(h.Key, h.Value)}"));
}
