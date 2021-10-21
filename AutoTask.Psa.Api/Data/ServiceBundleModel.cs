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
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BillingCodeID
		/// </summary>
		[DataMember(Name = "BillingCodeID")]
		public int? BillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate")]
		public DateTime? CreateDate { get; set; }

		/// <summary>
		/// Gets or Sets CreatorResourceID
		/// </summary>
		[DataMember(Name = "CreatorResourceID")]
		public int? CreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets InvoiceDescription
		/// </summary>
		[DataMember(Name = "InvoiceDescription")]
		public string InvoiceDescription { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive")]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedDate
		/// </summary>
		[DataMember(Name = "LastModifiedDate")]
		public DateTime? LastModifiedDate { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets PercentageDiscount
		/// </summary>
		[DataMember(Name = "PercentageDiscount")]
		public double? PercentageDiscount { get; set; }

		/// <summary>
		/// Gets or Sets PeriodType
		/// </summary>
		[DataMember(Name = "PeriodType")]
		public int? PeriodType { get; set; }

		/// <summary>
		/// Gets or Sets ServiceLevelAgreementID
		/// </summary>
		[DataMember(Name = "ServiceLevelAgreementID")]
		public long? ServiceLevelAgreementID { get; set; }

		/// <summary>
		/// Gets or Sets UnitCost
		/// </summary>
		[DataMember(Name = "UnitCost")]
		public double? UnitCost { get; set; }

		/// <summary>
		/// Gets or Sets UnitDiscount
		/// </summary>
		[DataMember(Name = "UnitDiscount")]
		public double? UnitDiscount { get; set; }

		/// <summary>
		/// Gets or Sets UnitPrice
		/// </summary>
		[DataMember(Name = "UnitPrice")]
		public double? UnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets UpdateResourceID
		/// </summary>
		[DataMember(Name = "UpdateResourceID")]
		public int? UpdateResourceID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
