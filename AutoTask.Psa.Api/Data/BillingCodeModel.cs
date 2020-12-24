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
		/// Initializes a new instance of the <see cref="BillingCodeModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AfterHoursWorkType">AfterHoursWorkType.</param>
		/// <param name="BillingCodeType">BillingCodeType.</param>
		/// <param name="Department">Department.</param>
		/// <param name="Description">Description.</param>
		/// <param name="ExternalNumber">ExternalNumber.</param>
		/// <param name="GeneralLedgerAccount">GeneralLedgerAccount.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsExcludedFromNewContracts">IsExcludedFromNewContracts.</param>
		/// <param name="MarkupRate">MarkupRate.</param>
		/// <param name="Name">Name.</param>
		/// <param name="TaxCategoryID">TaxCategoryID.</param>
		/// <param name="UnitCost">UnitCost.</param>
		/// <param name="UnitPrice">UnitPrice.</param>
		/// <param name="UseType">UseType.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public BillingCodeModel(long? Id = default, int? AfterHoursWorkType = default, int? BillingCodeType = default, int? Department = default, string Description = default, string ExternalNumber = default, int? GeneralLedgerAccount = default, bool? IsActive = default, bool? IsExcludedFromNewContracts = default, double? MarkupRate = default, string Name = default, int? TaxCategoryID = default, double? UnitCost = default, double? UnitPrice = default, int? UseType = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AfterHoursWorkType = AfterHoursWorkType;
			this.BillingCodeType = BillingCodeType;
			this.Department = Department;
			this.Description = Description;
			this.ExternalNumber = ExternalNumber;
			this.GeneralLedgerAccount = GeneralLedgerAccount;
			this.IsActive = IsActive;
			this.IsExcludedFromNewContracts = IsExcludedFromNewContracts;
			this.MarkupRate = MarkupRate;
			this.Name = Name;
			this.TaxCategoryID = TaxCategoryID;
			this.UnitCost = UnitCost;
			this.UnitPrice = UnitPrice;
			this.UseType = UseType;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets ExternalNumber
		/// </summary>
		[DataMember(Name = "ExternalNumber", EmitDefaultValue = false)]
		public string ExternalNumber { get; set; }

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
		public string Name { get; set; }

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
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
