using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractMilestoneModel
	/// </summary>
	[DataContract]
	public partial class ContractMilestoneModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractMilestoneModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Amount">Amount.</param>
		/// <param name="BillingCodeID">BillingCodeID.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="CreateDate">CreateDate.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="DateDue">DateDue.</param>
		/// <param name="Description">Description.</param>
		/// <param name="InternalCurrencyAmount">InternalCurrencyAmount.</param>
		/// <param name="IsInitialPayment">IsInitialPayment.</param>
		/// <param name="OrganizationalLevelAssociationID">OrganizationalLevelAssociationID.</param>
		/// <param name="Status">Status.</param>
		/// <param name="Title">Title.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractMilestoneModel(long? Id = default, double? Amount = default, int? BillingCodeID = default, int? ContractID = default, DateTime? CreateDate = default, int? CreatorResourceID = default, DateTime? DateDue = default, string Description = default, double? InternalCurrencyAmount = default, bool? IsInitialPayment = default, int? OrganizationalLevelAssociationID = default, int? Status = default, string Title = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.Amount = Amount;
			this.BillingCodeID = BillingCodeID;
			this.ContractID = ContractID;
			this.CreateDate = CreateDate;
			this.CreatorResourceID = CreatorResourceID;
			this.DateDue = DateDue;
			this.Description = Description;
			this.InternalCurrencyAmount = InternalCurrencyAmount;
			this.IsInitialPayment = IsInitialPayment;
			this.OrganizationalLevelAssociationID = OrganizationalLevelAssociationID;
			this.Status = Status;
			this.Title = Title;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets Amount
		/// </summary>
		[DataMember(Name = "Amount", EmitDefaultValue = false)]
		public double? Amount { get; set; }

		/// <summary>
		/// Gets or Sets BillingCodeID
		/// </summary>
		[DataMember(Name = "BillingCodeID", EmitDefaultValue = false)]
		public int? BillingCodeID { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

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
		/// Gets or Sets DateDue
		/// </summary>
		[DataMember(Name = "DateDue", EmitDefaultValue = false)]
		public DateTime? DateDue { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyAmount
		/// </summary>
		[DataMember(Name = "InternalCurrencyAmount", EmitDefaultValue = false)]
		public double? InternalCurrencyAmount { get; set; }

		/// <summary>
		/// Gets or Sets IsInitialPayment
		/// </summary>
		[DataMember(Name = "IsInitialPayment", EmitDefaultValue = false)]
		public bool? IsInitialPayment { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncContractMilestoneInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
