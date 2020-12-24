using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ServiceBundleModel
	/// </summary>
	[DataContract]
	public partial class ServiceBundleModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceBundleModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BillingCodeID">BillingCodeID.</param>
		/// <param name="CreateDate">CreateDate.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="InvoiceDescription">InvoiceDescription.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="LastModifiedDate">LastModifiedDate.</param>
		/// <param name="Name">Name.</param>
		/// <param name="PercentageDiscount">PercentageDiscount.</param>
		/// <param name="PeriodType">PeriodType.</param>
		/// <param name="ServiceLevelAgreementID">ServiceLevelAgreementID.</param>
		/// <param name="UnitCost">UnitCost.</param>
		/// <param name="UnitDiscount">UnitDiscount.</param>
		/// <param name="UnitPrice">UnitPrice.</param>
		/// <param name="UpdateResourceID">UpdateResourceID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ServiceBundleModel(long? Id = default, int? BillingCodeID = default, DateTime? CreateDate = default, int? CreatorResourceID = default, string Description = default, string InvoiceDescription = default, bool? IsActive = default, DateTime? LastModifiedDate = default, string Name = default, double? PercentageDiscount = default, int? PeriodType = default, long? ServiceLevelAgreementID = default, double? UnitCost = default, double? UnitDiscount = default, double? UnitPrice = default, int? UpdateResourceID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BillingCodeID = BillingCodeID;
			this.CreateDate = CreateDate;
			this.CreatorResourceID = CreatorResourceID;
			this.Description = Description;
			this.InvoiceDescription = InvoiceDescription;
			this.IsActive = IsActive;
			this.LastModifiedDate = LastModifiedDate;
			this.Name = Name;
			this.PercentageDiscount = PercentageDiscount;
			this.PeriodType = PeriodType;
			this.ServiceLevelAgreementID = ServiceLevelAgreementID;
			this.UnitCost = UnitCost;
			this.UnitDiscount = UnitDiscount;
			this.UnitPrice = UnitPrice;
			this.UpdateResourceID = UpdateResourceID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BillingCodeID
		/// </summary>
		[DataMember(Name = "BillingCodeID", EmitDefaultValue = false)]
		public int? BillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate", EmitDefaultValue = false)]
		public DateTime? CreateDate { get; set; }

		/// <summary>
		/// Gets or Sets CreatorResourceID
		/// </summary>
		[DataMember(Name = "CreatorResourceID", EmitDefaultValue = false)]
		public int? CreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceDescription
		/// </summary>
		[DataMember(Name = "InvoiceDescription", EmitDefaultValue = false)]
		public string InvoiceDescription { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedDate
		/// </summary>
		[DataMember(Name = "LastModifiedDate", EmitDefaultValue = false)]
		public DateTime? LastModifiedDate { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PercentageDiscount
		/// </summary>
		[DataMember(Name = "PercentageDiscount", EmitDefaultValue = false)]
		public double? PercentageDiscount { get; set; }

		/// <summary>
		/// Gets or Sets PeriodType
		/// </summary>
		[DataMember(Name = "PeriodType", EmitDefaultValue = false)]
		public int? PeriodType { get; set; }

		/// <summary>
		/// Gets or Sets ServiceLevelAgreementID
		/// </summary>
		[DataMember(Name = "ServiceLevelAgreementID", EmitDefaultValue = false)]
		public long? ServiceLevelAgreementID { get; set; }

		/// <summary>
		/// Gets or Sets UnitCost
		/// </summary>
		[DataMember(Name = "UnitCost", EmitDefaultValue = false)]
		public double? UnitCost { get; set; }

		/// <summary>
		/// Gets or Sets UnitDiscount
		/// </summary>
		[DataMember(Name = "UnitDiscount", EmitDefaultValue = false)]
		public double? UnitDiscount { get; set; }

		/// <summary>
		/// Gets or Sets UnitPrice
		/// </summary>
		[DataMember(Name = "UnitPrice", EmitDefaultValue = false)]
		public double? UnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets UpdateResourceID
		/// </summary>
		[DataMember(Name = "UpdateResourceID", EmitDefaultValue = false)]
		public int? UpdateResourceID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
