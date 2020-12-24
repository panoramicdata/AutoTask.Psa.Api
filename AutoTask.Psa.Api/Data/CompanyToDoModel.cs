using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CompanyToDoModel
	/// </summary>
	[DataContract]
	public partial class CompanyToDoModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CompanyToDoModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ActionType">ActionType.</param>
		/// <param name="ActivityDescription">ActivityDescription.</param>
		/// <param name="AssignedToResourceID">AssignedToResourceID.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="CompletedDate">CompletedDate.</param>
		/// <param name="ContactID">ContactID.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="CreateDateTime">CreateDateTime.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="EndDateTime">EndDateTime.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="LastModifiedDate">LastModifiedDate.</param>
		/// <param name="OpportunityID">OpportunityID.</param>
		/// <param name="StartDateTime">StartDateTime.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public CompanyToDoModel(long? Id = default, int? ActionType = default, string ActivityDescription = default, long? AssignedToResourceID = default, long? CompanyID = default, DateTime? CompletedDate = default, long? ContactID = default, long? ContractID = default, DateTime? CreateDateTime = default, long? CreatorResourceID = default, DateTime? EndDateTime = default, int? ImpersonatorCreatorResourceID = default, DateTime? LastModifiedDate = default, long? OpportunityID = default, DateTime? StartDateTime = default, long? TicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ActionType = ActionType;
			this.ActivityDescription = ActivityDescription;
			this.AssignedToResourceID = AssignedToResourceID;
			this.CompanyID = CompanyID;
			this.CompletedDate = CompletedDate;
			this.ContactID = ContactID;
			this.ContractID = ContractID;
			this.CreateDateTime = CreateDateTime;
			this.CreatorResourceID = CreatorResourceID;
			this.EndDateTime = EndDateTime;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.LastModifiedDate = LastModifiedDate;
			this.OpportunityID = OpportunityID;
			this.StartDateTime = StartDateTime;
			this.TicketID = TicketID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ActionType
		/// </summary>
		[DataMember(Name = "ActionType", EmitDefaultValue = false)]
		public int? ActionType { get; set; }

		/// <summary>
		/// Gets or Sets ActivityDescription
		/// </summary>
		[DataMember(Name = "ActivityDescription", EmitDefaultValue = false)]
		public string ActivityDescription { get; set; }

		/// <summary>
		/// Gets or Sets AssignedToResourceID
		/// </summary>
		[DataMember(Name = "AssignedToResourceID", EmitDefaultValue = false)]
		public long? AssignedToResourceID { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public long? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets CompletedDate
		/// </summary>
		[DataMember(Name = "CompletedDate", EmitDefaultValue = false)]
		public DateTime? CompletedDate { get; set; }

		/// <summary>
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public long? ContactID { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public long? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDateTime
		/// </summary>
		[DataMember(Name = "CreateDateTime", EmitDefaultValue = false)]
		public DateTime? CreateDateTime { get; set; }

		/// <summary>
		/// Gets or Sets CreatorResourceID
		/// </summary>
		[DataMember(Name = "CreatorResourceID", EmitDefaultValue = false)]
		public long? CreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets EndDateTime
		/// </summary>
		[DataMember(Name = "EndDateTime", EmitDefaultValue = false)]
		public DateTime? EndDateTime { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedDate
		/// </summary>
		[DataMember(Name = "LastModifiedDate", EmitDefaultValue = false)]
		public DateTime? LastModifiedDate { get; set; }

		/// <summary>
		/// Gets or Sets OpportunityID
		/// </summary>
		[DataMember(Name = "OpportunityID", EmitDefaultValue = false)]
		public long? OpportunityID { get; set; }

		/// <summary>
		/// Gets or Sets StartDateTime
		/// </summary>
		[DataMember(Name = "StartDateTime", EmitDefaultValue = false)]
		public DateTime? StartDateTime { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public long? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncAccountToDoInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
