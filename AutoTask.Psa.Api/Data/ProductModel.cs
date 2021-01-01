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
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BillingType
		/// </summary>
		[DataMember(Name = "BillingType", EmitDefaultValue = false)]
		public int? BillingType { get; set; }

		/// <summary>
		/// Gets or Sets ChargeBillingCodeID
		/// </summary>
		[DataMember(Name = "ChargeBillingCodeID", EmitDefaultValue = false)]
		public int? ChargeBillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets DefaultVendorID
		/// </summary>
		[DataMember(Name = "DefaultVendorID", EmitDefaultValue = false)]
		public int? DefaultVendorID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets DoesNotRequireProcurement
		/// </summary>
		[DataMember(Name = "DoesNotRequireProcurement", EmitDefaultValue = false)]
		public bool? DoesNotRequireProcurement { get; set; }

		/// <summary>
		/// Gets or Sets ExternalProductID
		/// </summary>
		[DataMember(Name = "ExternalProductID", EmitDefaultValue = false)]
		public string ExternalProductID { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets InternalProductID
		/// </summary>
		[DataMember(Name = "InternalProductID", EmitDefaultValue = false)]
		public string InternalProductID { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsEligibleForRma
		/// </summary>
		[DataMember(Name = "IsEligibleForRma", EmitDefaultValue = false)]
		public bool? IsEligibleForRma { get; set; }

		/// <summary>
		/// Gets or Sets IsSerialized
		/// </summary>
		[DataMember(Name = "IsSerialized", EmitDefaultValue = false)]
		public bool? IsSerialized { get; set; }

		/// <summary>
		/// Gets or Sets Link
		/// </summary>
		[DataMember(Name = "Link", EmitDefaultValue = false)]
		public string Link { get; set; }

		/// <summary>
		/// Gets or Sets ManufacturerName
		/// </summary>
		[DataMember(Name = "ManufacturerName", EmitDefaultValue = false)]
		public string ManufacturerName { get; set; }

		/// <summary>
		/// Gets or Sets ManufacturerProductName
		/// </summary>
		[DataMember(Name = "ManufacturerProductName", EmitDefaultValue = false)]
		public string ManufacturerProductName { get; set; }

		/// <summary>
		/// Gets or Sets MarkupRate
		/// </summary>
		[DataMember(Name = "MarkupRate", EmitDefaultValue = false)]
		public double? MarkupRate { get; set; }

		/// <summary>
		/// Gets or Sets MSRP
		/// </summary>
		[DataMember(Name = "MSRP", EmitDefaultValue = false)]
		public double? MSRP { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PeriodType
		/// </summary>
		[DataMember(Name = "PeriodType", EmitDefaultValue = false)]
		public int? PeriodType { get; set; }

		/// <summary>
		/// Gets or Sets PriceCostMethod
		/// </summary>
		[DataMember(Name = "PriceCostMethod", EmitDefaultValue = false)]
		public int? PriceCostMethod { get; set; }

		/// <summary>
		/// Gets or Sets ProductBillingCodeID
		/// </summary>
		[DataMember(Name = "ProductBillingCodeID", EmitDefaultValue = false)]
		public int? ProductBillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets ProductCategory
		/// </summary>
		[DataMember(Name = "ProductCategory", EmitDefaultValue = false)]
		public int? ProductCategory { get; set; }

		/// <summary>
		/// Gets or Sets SKU
		/// </summary>
		[DataMember(Name = "SKU", EmitDefaultValue = false)]
		public string SKU { get; set; }

		/// <summary>
		/// Gets or Sets UnitCost
		/// </summary>
		[DataMember(Name = "UnitCost", EmitDefaultValue = false)]
		public double? UnitCost { get; set; }

		/// <summary>
		/// Gets or Sets UnitPrice
		/// </summary>
		[DataMember(Name = "UnitPrice", EmitDefaultValue = false)]
		public double? UnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets VendorProductNumber
		/// </summary>
		[DataMember(Name = "VendorProductNumber", EmitDefaultValue = false)]
		public string VendorProductNumber { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
