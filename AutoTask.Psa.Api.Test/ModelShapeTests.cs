using System.Reflection;
using System.Text.Json;

namespace AutoTask.Psa.Api.Test;

/// <summary>
/// Characterisation tests for the entity models whose shared properties were pulled up into
/// abstract base classes.
///
/// <para>
/// Moving a property to a base type must not change what a consumer sees or what goes on the wire:
/// <c>GetProperties()</c> still reports inherited members, and System.Text.Json still serialises
/// them. These tests pin both, so the refactor is provably behaviour-preserving rather than
/// merely compiling.
/// </para>
/// </summary>
public class ModelShapeTests
{
	private static readonly JsonSerializerOptions Options = new(JsonSerializerDefaults.Web);

	private static string[] PropertyNames<T>()
		=> [.. typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
			.Select(p => p.Name)
			.OrderBy(n => n, StringComparer.Ordinal)];

	/// <summary>
	/// The 17 properties every attachment entity carries. ParentType and IsTaskAttachment are
	/// declared with private setters, so System.Text.Json never populates them; that is preserved
	/// here rather than changed, because fixing it is a behaviour change and not part of this
	/// refactor.
	/// </summary>
	private static readonly string[] AttachmentProperties =
	[
		"AttachDate", "AttachedByContactID", "AttachedByResourceID", "AttachmentType",
		"ContentType", "Data", "FileSize", "FullPath", "Id", "ImpersonatorCreatorResourceID",
		"IsTaskAttachment", "OpportunityID", "ParentID", "ParentType", "Publish",
		"SoapParentPropertyId", "Title"
	];

	[Fact]
	public void AttachmentModels_AllExposeTheSameSeventeenProperties()
	{
		PropertyNames<CompanyAttachmentModel>().Should().Equal(AttachmentProperties);
		PropertyNames<OpportunityAttachmentModel>().Should().Equal(AttachmentProperties);
		PropertyNames<ProjectAttachmentModel>().Should().Equal(AttachmentProperties);
		PropertyNames<TaskAttachmentModel>().Should().Equal(AttachmentProperties);
		PropertyNames<TicketAttachmentModel>().Should().Equal(AttachmentProperties);
	}

	[Fact]
	public void WebhookModels_ExposeTheSameProperties()
		=> PropertyNames<CompanyWebhookModel>().Should().Equal(PropertyNames<ContactWebhookModel>());

	[Fact]
	public void WebhookFieldModels_ExposeTheSameProperties()
		=> PropertyNames<CompanyWebhookFieldModel>().Should().Equal(PropertyNames<ContactWebhookFieldModel>());

	[Fact]
	public void WebhookUdfFieldModels_ExposeTheSameProperties()
		=> PropertyNames<CompanyWebhookUdfFieldModel>().Should().Equal(PropertyNames<ContactWebhookUdfFieldModel>());

	[Fact]
	public void WebhookExcludedResourceModels_ExposeTheSameProperties()
		=> PropertyNames<CompanyWebhookExcludedResourceModel>().Should().Equal(PropertyNames<ContactWebhookExcludedResourceModel>());

	[Fact]
	public void ChargeModels_ShareTheTwentyOneCommonChargeProperties()
	{
		string[] shared =
		[
			"BillableAmount", "ChargeType", "CreateDate", "DatePurchased", "Description",
			"ExtendedCost", "Id", "InternalCurrencyBillableAmount", "InternalCurrencyUnitPrice",
			"InternalPurchaseOrderNumber", "IsBillableToCompany", "IsBilled", "Name", "Notes",
			"OrganizationalLevelAssociationID", "PurchaseOrderNumber", "StatusLastModifiedDate",
			"UnitCost", "UnitPrice", "UnitQuantity", "UserDefinedFields"
		];

		foreach (var names in new[]
		{
			PropertyNames<ChangeOrderChargeModel>(),
			PropertyNames<ContractChargeModel>(),
			PropertyNames<ProjectChargeModel>(),
			PropertyNames<TicketChargeModel>()
		})
		{
			names.Should().Contain(shared);
		}
	}

	[Fact]
	public void AttachmentModel_RoundTripsEveryProperty()
	{
		var original = new TicketAttachmentModel
		{
			Id = 7,
			AttachDate = new DateTime(2026, 1, 2, 3, 4, 5, DateTimeKind.Utc),
			AttachedByContactID = 11,
			AttachedByResourceID = 12,
			AttachmentType = "FILE_ATTACHMENT",
			ContentType = "text/plain",
			FileSize = 123.5,
			FullPath = @"\\server\share\file.txt",
			ImpersonatorCreatorResourceID = 13,
			OpportunityID = 14,
			ParentID = 15,
			Publish = 1,
			Title = "a title",
			Data = [1, 2, 3]
		};

		var json = JsonSerializer.Serialize(original, Options);
		var round = JsonSerializer.Deserialize<TicketAttachmentModel>(json, Options);

		round.Should().BeEquivalentTo(original, because: "inherited properties must serialise too");
		json.Should().Contain("\"attachDate\"").And.Contain("\"fullPath\"").And.Contain("\"title\"");
	}

	[Fact]
	public void ChargeModel_RoundTripsInheritedAndOwnProperties()
	{
		var original = new TicketChargeModel
		{
			Id = 9,
			Description = "a charge",
			Name = "charge name",
			UnitPrice = 10.5,
			UnitQuantity = 2,
			IsBilled = false,
			CreateDate = new DateTime(2026, 5, 6, 7, 8, 9, DateTimeKind.Utc)
		};

		var json = JsonSerializer.Serialize(original, Options);
		var round = JsonSerializer.Deserialize<TicketChargeModel>(json, Options);

		round.Should().BeEquivalentTo(original);
	}

	[Fact]
	public void WebhookModel_RoundTripsInheritedProperties()
	{
		var original = new CompanyWebhookModel
		{
			Id = 3,
			Name = "hook",
			WebhookUrl = "https://example.invalid/hook",
			IsActive = true,
			IsSubscribedToCreateEvents = true,
			SecretKey = "s3cret"
		};

		var json = JsonSerializer.Serialize(original, Options);
		var round = JsonSerializer.Deserialize<CompanyWebhookModel>(json, Options);

		round.Should().BeEquivalentTo(original);
	}
}
