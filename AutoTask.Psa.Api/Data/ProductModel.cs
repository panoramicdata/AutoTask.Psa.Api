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
		/// Initializes a new instance of the <see cref="ProductModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BillingType">BillingType.</param>
		/// <param name="ChargeBillingCodeID">ChargeBillingCodeID.</param>
		/// <param name="DefaultVendorID">DefaultVendorID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="DoesNotRequireProcurement">DoesNotRequireProcurement.</param>
		/// <param name="ExternalProductID">ExternalProductID.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="InternalProductID">InternalProductID.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsEligibleForRma">IsEligibleForRma.</param>
		/// <param name="IsSerialized">IsSerialized.</param>
		/// <param name="Link">Link.</param>
		/// <param name="ManufacturerName">ManufacturerName.</param>
		/// <param name="ManufacturerProductName">ManufacturerProductName.</param>
		/// <param name="MarkupRate">MarkupRate.</param>
		/// <param name="MSRP">MSRP.</param>
		/// <param name="Name">Name.</param>
		/// <param name="PeriodType">PeriodType.</param>
		/// <param name="PriceCostMethod">PriceCostMethod.</param>
		/// <param name="ProductBillingCodeID">ProductBillingCodeID.</param>
		/// <param name="ProductCategory">ProductCategory.</param>
		/// <param name="SKU">SKU.</param>
		/// <param name="UnitCost">UnitCost.</param>
		/// <param name="UnitPrice">UnitPrice.</param>
		/// <param name="VendorProductNumber">VendorProductNumber.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ProductModel(long? Id = default, int? BillingType = default, int? ChargeBillingCodeID = default, int? DefaultVendorID = default, string Description = default, bool? DoesNotRequireProcurement = default, string ExternalProductID = default, int? ImpersonatorCreatorResourceID = default, string InternalProductID = default, bool? IsActive = default, bool? IsEligibleForRma = default, bool? IsSerialized = default, string Link = default, string ManufacturerName = default, string ManufacturerProductName = default, double? MarkupRate = default, double? MSRP = default, string Name = default, int? PeriodType = default, int? PriceCostMethod = default, int? ProductBillingCodeID = default, int? ProductCategory = default, string SKU = default, double? UnitCost = default, double? UnitPrice = default, string VendorProductNumber = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BillingType = BillingType;
			this.ChargeBillingCodeID = ChargeBillingCodeID;
			this.DefaultVendorID = DefaultVendorID;
			this.Description = Description;
			this.DoesNotRequireProcurement = DoesNotRequireProcurement;
			this.ExternalProductID = ExternalProductID;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.InternalProductID = InternalProductID;
			this.IsActive = IsActive;
			this.IsEligibleForRma = IsEligibleForRma;
			this.IsSerialized = IsSerialized;
			this.Link = Link;
			this.ManufacturerName = ManufacturerName;
			this.ManufacturerProductName = ManufacturerProductName;
			this.MarkupRate = MarkupRate;
			this.MSRP = MSRP;
			this.Name = Name;
			this.PeriodType = PeriodType;
			this.PriceCostMethod = PriceCostMethod;
			this.ProductBillingCodeID = ProductBillingCodeID;
			this.ProductCategory = ProductCategory;
			this.SKU = SKU;
			this.UnitCost = UnitCost;
			this.UnitPrice = UnitPrice;
			this.VendorProductNumber = VendorProductNumber;
			this.UserDefinedFields = UserDefinedFields;
		}

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
