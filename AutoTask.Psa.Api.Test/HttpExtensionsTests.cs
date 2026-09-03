using System.Net.Http;
using System.Net.Http.Headers;

namespace AutoTask.Psa.Api.Test;

/// <summary>
/// Tests for header redaction in diagnostic output.
///
/// <para>
/// <c>AuthenticatedHttpClientHandler</c> adds three bespoke authentication headers to every request
/// and then logged the header collection at Debug. <c>HttpHeaders.ToString()</c> applies no
/// filtering, so all three were written verbatim wherever those messages ended up.
/// </para>
///
/// <para>
/// AutoTask does not use an Authorization header at all. Its credentials are
/// <c>ApiIntegrationCode</c>, <c>UserName</c> and <c>Secret</c>, the last of which carries the
/// account password in plain text. A redaction list copied from a sibling package would have missed
/// every one of them.
/// </para>
///
/// <para>
/// These are pure unit tests. They construct headers directly and require no credentials, no
/// configuration and no live instance.
/// </para>
/// </summary>
public class HttpExtensionsTests
{
	private const string FakePassword = "n0t-a-real-password-but-shaped-like-one";

	/// <summary>
	/// The headline case: the raw account password must not survive into the message.
	/// </summary>
	[Fact]
	public void ToDebugString_SecretHeader_DoesNotLeakThePassword()
	{
		using var request = new HttpRequestMessage();
		request.Headers.Add("Secret", FakePassword);

		var debugString = request.Headers.ToDebugString();

		debugString.Should().NotContain(FakePassword);
		debugString.Should().Be($"Secret: <redacted, length {FakePassword.Length}>");
	}

	/// <summary>
	/// Proves the defect being fixed: the framework rendering leaks, the replacement does not.
	/// </summary>
	[Fact]
	public void ToDebugString_UnlikeToString_DoesNotContainTheCredentials()
	{
		using var request = new HttpRequestMessage();
		request.Headers.Add("Secret", FakePassword);

		request.Headers.ToString().Should().Contain(FakePassword, "the framework rendering is what leaked");
		request.Headers.ToDebugString().Should().NotContain(FakePassword);
	}

	/// <summary>
	/// All three AutoTask authentication headers are credentials and all three must go. Set exactly as
	/// <c>AuthenticatedHttpClientHandler</c> sets them, so this fails if that changes.
	/// </summary>
	[Fact]
	public void ToDebugString_AllThreeAutoTaskCredentialHeaders_AreRedacted()
	{
		using var request = new HttpRequestMessage();
		request.Headers.Add("ApiIntegrationCode", "INTEGRATION-CODE-12345");
		request.Headers.Add("UserName", "api-user@example.com");
		request.Headers.Add("Secret", FakePassword);

		var debugString = request.Headers.ToDebugString();

		debugString.Should().NotContain("INTEGRATION-CODE-12345");
		debugString.Should().NotContain("api-user@example.com");
		debugString.Should().NotContain(FakePassword);
		debugString.Should().Contain("ApiIntegrationCode: <redacted");
		debugString.Should().Contain("UserName: <redacted");
		debugString.Should().Contain("Secret: <redacted");
	}

	/// <summary>
	/// A header added without validation keeps whatever casing the caller used.
	/// </summary>
	/// <param name="headerName">The header name casing under test.</param>
	[Theory]
	[InlineData("secret")]
	[InlineData("SECRET")]
	[InlineData("username")]
	[InlineData("apiintegrationcode")]
	public void ToDebugString_CredentialHeaders_AreRedactedWhateverTheCasing(string headerName)
	{
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation(headerName, FakePassword);

		var debugString = request.Headers.ToDebugString();

		debugString.Should().NotContain(FakePassword);
		debugString.Should().Contain("<redacted");
	}

	/// <summary>
	/// The standard credential-bearing header names are redacted too.
	/// </summary>
	/// <param name="headerName">The credential-bearing header name under test.</param>
	[Theory]
	[InlineData("Authorization")]
	[InlineData("Proxy-Authorization")]
	[InlineData("Cookie")]
	[InlineData("X-API-Key")]
	[InlineData("Api-Key")]
	[InlineData("X-Api-Token")]
	[InlineData("X-Auth-Token")]
	public void ToDebugString_StandardCredentialHeaders_AreRedacted(string headerName)
	{
		const string secret = "s3cr3t-value-that-must-not-be-logged";
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation(headerName, secret);

		var debugString = request.Headers.ToDebugString();

		debugString.Should().NotContain(secret);
		debugString.Should().Contain("<redacted");
	}

	/// <summary>
	/// Where a scheme is present it is kept, because knowing which mechanism was used aids diagnosis.
	/// </summary>
	[Fact]
	public void ToDebugString_BearerToken_KeepsTheSchemeAndLength()
	{
		const string token = "abcdefghijklmnopqrstuvwxyz0123456789";
		using var request = new HttpRequestMessage();
		request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

		var debugString = request.Headers.ToDebugString();

		debugString.Should().Be($"Authorization: Bearer <redacted, length {token.Length}>");
	}

	/// <summary>
	/// A cookie value also contains a space, so treating the text before the first space as a scheme
	/// would preserve the very value being redacted. Only Authorization style headers keep a scheme.
	/// </summary>
	[Fact]
	public void ToDebugString_CookieValueContainingASpace_IsRedactedWhole()
	{
		const string cookie = "session=abc123def456; HttpOnly";
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation("Cookie", cookie);

		var debugString = request.Headers.ToDebugString();

		debugString.Should().Be($"Cookie: <redacted, length {cookie.Length}>");
		debugString.Should().NotContain("session=");
	}

	/// <summary>
	/// Redaction must be surgical: the useful headers alongside the credentials must survive intact.
	/// </summary>
	[Fact]
	public void ToDebugString_RedactsOnlyTheSensitiveHeaders()
	{
		using var request = new HttpRequestMessage();
		request.Headers.Add("Secret", FakePassword);
		request.Headers.Add("UserAgent", "AutoTask.Psa.Api.AutoTaskClient");

		var debugString = request.Headers.ToDebugString();

		debugString.Should().NotContain(FakePassword);
		debugString.Should().Contain("UserAgent: AutoTask.Psa.Api.AutoTaskClient");
	}

	/// <summary>
	/// A vendor may prefix the standard header name rather than using it directly.
	/// </summary>
	[Fact]
	public void ToDebugString_VendorPrefixedAuthorizationHeader_IsRedacted()
	{
		const string token = "abcdefghijklmnopqrstuvwxyz";
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation("X-Vendor-Authorization", $"Bearer {token}");

		var debugString = request.Headers.ToDebugString();

		debugString.Should().NotContain(token);
		debugString.Should().Contain("<redacted");
	}

	/// <summary>
	/// A request carrying no credential is rendered with nothing removed.
	/// </summary>
	[Fact]
	public void ToDebugString_NonSensitiveHeader_IsUnchanged()
	{
		using var request = new HttpRequestMessage();
		request.Headers.TryAddWithoutValidation("UserAgent", "AutoTask.Psa.Api.AutoTaskClient");

		var debugString = request.Headers.ToDebugString();

		debugString.Should().Be("UserAgent: AutoTask.Psa.Api.AutoTaskClient");
	}

	/// <summary>
	/// An empty header collection produces no output at all.
	/// </summary>
	[Fact]
	public void ToDebugString_NoHeaders_IsEmpty()
	{
		using var request = new HttpRequestMessage();

		request.Headers.ToDebugString().Should().BeEmpty();
	}
}
