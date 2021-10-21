using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ProductModel
	/// </summary>
	[DataContract]
	public partial class ProductModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BillingType
		/// </summary>
		[DataMember(Name = "BillingType")]
		public int? BillingType { get; set; }

		/// <summary>
		/// Gets or Sets ChargeBillingCodeID
		/// </summary>
		[DataMember(Name = "ChargeBillingCodeID")]
		public int? ChargeBillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets DefaultVendorID
		/// </summary>
		[DataMember(Name = "DefaultVendorID")]
		public int? DefaultVendorID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DoesNotRequireProcurement
		/// </summary>
		[DataMember(Name = "DoesNotRequireProcurement")]
		public bool? DoesNotRequireProcurement { get; set; }

		/// <summary>
		/// Gets or Sets ExternalProductID
		/// </summary>
		[DataMember(Name = "ExternalProductID")]
		public string ExternalProductID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID")]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets InternalProductID
		/// </summary>
		[DataMember(Name = "InternalProductID")]
		public string InternalProductID { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive")]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsEligibleForRma
		/// </summary>
		[DataMember(Name = "IsEligibleForRma")]
		public bool? IsEligibleForRma { get; set; }

		/// <summary>
		/// Gets or Sets IsSerialized
		/// </summary>
		[DataMember(Name = "IsSerialized")]
		public bool? IsSerialized { get; set; }

		/// <summary>
		/// Gets or Sets Link
		/// </summary>
		[DataMember(Name = "Link")]
		public string Link { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ManufacturerName
		/// </summary>
		[DataMember(Name = "ManufacturerName")]
		public string ManufacturerName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ManufacturerProductName
		/// </summary>
		[DataMember(Name = "ManufacturerProductName")]
		public string ManufacturerProductName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets MarkupRate
		/// </summary>
		[DataMember(Name = "MarkupRate")]
		public double? MarkupRate { get; set; }

		/// <summary>
		/// Gets or Sets MSRP
		/// </summary>
		[DataMember(Name = "MSRP")]
		public double? MSRP { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets PeriodType
		/// </summary>
		[DataMember(Name = "PeriodType")]
		public int? PeriodType { get; set; }

		/// <summary>
		/// Gets or Sets PriceCostMethod
		/// </summary>
		[DataMember(Name = "PriceCostMethod")]
		public int? PriceCostMethod { get; set; }

		/// <summary>
		/// Gets or Sets ProductBillingCodeID
		/// </summary>
		[DataMember(Name = "ProductBillingCodeID")]
		public int? ProductBillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets ProductCategory
		/// </summary>
		[DataMember(Name = "ProductCategory")]
		public int? ProductCategory { get; set; }

		/// <summary>
		/// Gets or Sets SKU
		/// </summary>
		[DataMember(Name = "SKU")]
		public string SKU { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets UnitCost
		/// </summary>
		[DataMember(Name = "UnitCost")]
		public double? UnitCost { get; set; }

		/// <summary>
		/// Gets or Sets UnitPrice
		/// </summary>
		[DataMember(Name = "UnitPrice")]
		public double? UnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets VendorProductNumber
		/// </summary>
		[DataMember(Name = "VendorProductNumber")]
		public string VendorProductNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
