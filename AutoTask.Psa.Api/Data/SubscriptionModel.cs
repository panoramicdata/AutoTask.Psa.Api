using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// SubscriptionModel
	/// </summary>
	[DataContract]
	public partial class SubscriptionModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SubscriptionModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ConfigurationItemID">ConfigurationItemID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="EffectiveDate">EffectiveDate.</param>
		/// <param name="ExpirationDate">ExpirationDate.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="MaterialCodeID">MaterialCodeID.</param>
		/// <param name="OrganizationalLevelAssociationID">OrganizationalLevelAssociationID.</param>
		/// <param name="PeriodCost">PeriodCost.</param>
		/// <param name="PeriodPrice">PeriodPrice.</param>
		/// <param name="PeriodType">PeriodType.</param>
		/// <param name="PurchaseOrderNumber">PurchaseOrderNumber.</param>
		/// <param name="Status">Status.</param>
		/// <param name="SubscriptionName">SubscriptionName.</param>
		/// <param name="TotalCost">TotalCost.</param>
		/// <param name="TotalPrice">TotalPrice.</param>
		/// <param name="VendorID">VendorID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public SubscriptionModel(long? Id = default, int? ConfigurationItemID = default, string Description = default, DateTime? EffectiveDate = default, DateTime? ExpirationDate = default, int? ImpersonatorCreatorResourceID = default, int? MaterialCodeID = default, int? OrganizationalLevelAssociationID = default, double? PeriodCost = default, double? PeriodPrice = default, int? PeriodType = default, string PurchaseOrderNumber = default, int? Status = default, string SubscriptionName = default, double? TotalCost = default, double? TotalPrice = default, int? VendorID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ConfigurationItemID = ConfigurationItemID;
			this.Description = Description;
			this.EffectiveDate = EffectiveDate;
			this.ExpirationDate = ExpirationDate;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.MaterialCodeID = MaterialCodeID;
			this.OrganizationalLevelAssociationID = OrganizationalLevelAssociationID;
			this.PeriodCost = PeriodCost;
			this.PeriodPrice = PeriodPrice;
			this.PeriodType = PeriodType;
			this.PurchaseOrderNumber = PurchaseOrderNumber;
			this.Status = Status;
			this.SubscriptionName = SubscriptionName;
			this.TotalCost = TotalCost;
			this.TotalPrice = TotalPrice;
			this.VendorID = VendorID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ConfigurationItemID
		/// </summary>
		[DataMember(Name = "ConfigurationItemID", EmitDefaultValue = false)]
		public int? ConfigurationItemID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets EffectiveDate
		/// </summary>
		[DataMember(Name = "EffectiveDate", EmitDefaultValue = false)]
		public DateTime? EffectiveDate { get; set; }

		/// <summary>
		/// Gets or Sets ExpirationDate
		/// </summary>
		[DataMember(Name = "ExpirationDate", EmitDefaultValue = false)]
		public DateTime? ExpirationDate { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets MaterialCodeID
		/// </summary>
		[DataMember(Name = "MaterialCodeID", EmitDefaultValue = false)]
		public int? MaterialCodeID { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets PeriodCost
		/// </summary>
		[DataMember(Name = "PeriodCost", EmitDefaultValue = false)]
		public double? PeriodCost { get; set; }

		/// <summary>
		/// Gets or Sets PeriodPrice
		/// </summary>
		[DataMember(Name = "PeriodPrice", EmitDefaultValue = false)]
		public double? PeriodPrice { get; set; }

		/// <summary>
		/// Gets or Sets PeriodType
		/// </summary>
		[DataMember(Name = "PeriodType", EmitDefaultValue = false)]
		public int? PeriodType { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets SubscriptionName
		/// </summary>
		[DataMember(Name = "SubscriptionName", EmitDefaultValue = false)]
		public string SubscriptionName { get; set; }

		/// <summary>
		/// Gets or Sets TotalCost
		/// </summary>
		[DataMember(Name = "TotalCost", EmitDefaultValue = false)]
		public double? TotalCost { get; set; }

		/// <summary>
		/// Gets or Sets TotalPrice
		/// </summary>
		[DataMember(Name = "TotalPrice", EmitDefaultValue = false)]
		public double? TotalPrice { get; set; }

		/// <summary>
		/// Gets or Sets VendorID
		/// </summary>
		[DataMember(Name = "VendorID", EmitDefaultValue = false)]
		public int? VendorID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
