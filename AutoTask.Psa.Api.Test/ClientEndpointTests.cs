using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Reflection;

namespace AutoTask.Psa.Api.Test;

/// <summary>Offline checks that every endpoint property on <see cref="AutoTaskClient"/> builds its Refit proxy.</summary>
public class ClientEndpointTests
{
	private sealed class NoNetworkHandler : HttpMessageHandler
	{
		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
			=> throw new InvalidOperationException("No request should be sent while building endpoints.");
	}

	private static PropertyInfo[] EndpointProperties()
		=> [.. typeof(AutoTaskClient)
			.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
			.Where(p => p.PropertyType.IsInterface)];

	[Fact]
	public void EndpointProperties_AreDiscovered()
		=> EndpointProperties().Length.Should().BeGreaterThan(200);

	[Fact]
	public void EveryEndpointProperty_BuildsItsProxyOnceAndCachesIt()
	{
		using var http = new HttpClient(new NoNetworkHandler()) { BaseAddress = new Uri("https://example.invalid/atservicesrest/") };
		using var client = new AutoTaskClient(http);

		foreach (var property in EndpointProperties())
		{
			var first = property.GetValue(client);
			var second = property.GetValue(client);

			first.Should().NotBeNull(because: property.Name);
			property.PropertyType.IsInstanceOfType(first).Should().BeTrue(because: property.Name);
			second.Should().BeSameAs(first, because: property.Name);
		}
	}

	[Fact]
	public void Constructor_WithOptions_BuildsAClientAndDisposesTwiceSafely()
	{
		var options = new AutoTaskClientOptions
		{
			ServerId = 3,
			UserName = "user",
			Password = "pw",
			IntegrationCode = "code"
		};
		var client = new AutoTaskClient(options, Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance);

		client.Tickets.Should().NotBeNull();
		client.Dispose();

		var again = client.Dispose;
		again.Should().NotThrow();
	}

	[Theory]
	[InlineData(null, "u", "p", "c", "ServerId")]
	[InlineData(1, null, "p", "c", "UserName")]
	[InlineData(1, "u", null, "c", "Password")]
	[InlineData(1, "u", "p", null, "IntegrationCode")]
	public void Validate_NamesTheMissingOption(int? serverId, string? user, string? password, string? code, string missing)
	{
		var options = new AutoTaskClientOptions
		{
			ServerId = serverId,
			UserName = user,
			Password = password,
			IntegrationCode = code
		};

		var act = options.Validate;

		act.Should().Throw<ValidationException>().WithMessage($"{missing} missing.");
	}
}
