using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// BillingCodeModel
	/// </summary>
	[DataContract]
	public partial class BillingCodeModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AfterHoursWorkType
		/// </summary>
		[DataMember(Name = "AfterHoursWorkType", EmitDefaultValue = false)]
		public int? AfterHoursWorkType { get; set; }

		/// <summary>
		/// Gets or Sets BillingCodeType
		/// </summary>
		[DataMember(Name = "BillingCodeType", EmitDefaultValue = false)]
		public int? BillingCodeType { get; set; }

		/// <summary>
		/// Gets or Sets Department
		/// </summary>
		[DataMember(Name = "Department", EmitDefaultValue = false)]
		public int? Department { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets ExternalNumber
		/// </summary>
		[DataMember(Name = "ExternalNumber", EmitDefaultValue = false)]
		public string ExternalNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets GeneralLedgerAccount
		/// </summary>
		[DataMember(Name = "GeneralLedgerAccount", EmitDefaultValue = false)]
		public int? GeneralLedgerAccount { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsExcludedFromNewContracts
		/// </summary>
		[DataMember(Name = "IsExcludedFromNewContracts", EmitDefaultValue = false)]
		public bool? IsExcludedFromNewContracts { get; set; }

		/// <summary>
		/// Gets or Sets MarkupRate
		/// </summary>
		[DataMember(Name = "MarkupRate", EmitDefaultValue = false)]
		public double? MarkupRate { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets TaxCategoryID
		/// </summary>
		[DataMember(Name = "TaxCategoryID", EmitDefaultValue = false)]
		public int? TaxCategoryID { get; set; }

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
		/// Gets or Sets UseType
		/// </summary>
		[DataMember(Name = "UseType", EmitDefaultValue = false)]
		public int? UseType { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
