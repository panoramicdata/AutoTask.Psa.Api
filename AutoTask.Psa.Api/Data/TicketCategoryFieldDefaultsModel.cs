using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TicketCategoryFieldDefaultsModel
	/// </summary>
	[DataContract]
	public partial class TicketCategoryFieldDefaultsModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TicketCategoryFieldDefaultsModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Description">Description.</param>
		/// <param name="EstimatedHours">EstimatedHours.</param>
		/// <param name="IssueTypeID">IssueTypeID.</param>
		/// <param name="OrganizationalLevelAssociationID">OrganizationalLevelAssociationID.</param>
		/// <param name="Priority">Priority.</param>
		/// <param name="PurchaseOrderNumber">PurchaseOrderNumber.</param>
		/// <param name="QueueID">QueueID.</param>
		/// <param name="Resolution">Resolution.</param>
		/// <param name="ServiceLevelAgreementID">ServiceLevelAgreementID.</param>
		/// <param name="SourceID">SourceID.</param>
		/// <param name="Status">Status.</param>
		/// <param name="SubIssueTypeID">SubIssueTypeID.</param>
		/// <param name="TicketCategoryID">TicketCategoryID.</param>
		/// <param name="TicketTypeID">TicketTypeID.</param>
		/// <param name="Title">Title.</param>
		/// <param name="WorkTypeID">WorkTypeID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TicketCategoryFieldDefaultsModel(long? Id = default, string Description = default, double? EstimatedHours = default, int? IssueTypeID = default, int? OrganizationalLevelAssociationID = default, int? Priority = default, string PurchaseOrderNumber = default, int? QueueID = default, string Resolution = default, int? ServiceLevelAgreementID = default, int? SourceID = default, int? Status = default, int? SubIssueTypeID = default, int? TicketCategoryID = default, int? TicketTypeID = default, string Title = default, int? WorkTypeID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.Description = Description;
			this.EstimatedHours = EstimatedHours;
			this.IssueTypeID = IssueTypeID;
			this.OrganizationalLevelAssociationID = OrganizationalLevelAssociationID;
			this.Priority = Priority;
			this.PurchaseOrderNumber = PurchaseOrderNumber;
			this.QueueID = QueueID;
			this.Resolution = Resolution;
			this.ServiceLevelAgreementID = ServiceLevelAgreementID;
			this.SourceID = SourceID;
			this.Status = Status;
			this.SubIssueTypeID = SubIssueTypeID;
			this.TicketCategoryID = TicketCategoryID;
			this.TicketTypeID = TicketTypeID;
			this.Title = Title;
			this.WorkTypeID = WorkTypeID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets EstimatedHours
		/// </summary>
		[DataMember(Name = "EstimatedHours", EmitDefaultValue = false)]
		public double? EstimatedHours { get; set; }

		/// <summary>
		/// Gets or Sets IssueTypeID
		/// </summary>
		[DataMember(Name = "IssueTypeID", EmitDefaultValue = false)]
		public int? IssueTypeID { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets Priority
		/// </summary>
		[DataMember(Name = "Priority", EmitDefaultValue = false)]
		public int? Priority { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Gets or Sets QueueID
		/// </summary>
		[DataMember(Name = "QueueID", EmitDefaultValue = false)]
		public int? QueueID { get; set; }

		/// <summary>
		/// Gets or Sets Resolution
		/// </summary>
		[DataMember(Name = "Resolution", EmitDefaultValue = false)]
		public string Resolution { get; set; }

		/// <summary>
		/// Gets or Sets ServiceLevelAgreementID
		/// </summary>
		[DataMember(Name = "ServiceLevelAgreementID", EmitDefaultValue = false)]
		public int? ServiceLevelAgreementID { get; set; }

		/// <summary>
		/// Gets or Sets SourceID
		/// </summary>
		[DataMember(Name = "SourceID", EmitDefaultValue = false)]
		public int? SourceID { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets SubIssueTypeID
		/// </summary>
		[DataMember(Name = "SubIssueTypeID", EmitDefaultValue = false)]
		public int? SubIssueTypeID { get; set; }

		/// <summary>
		/// Gets or Sets TicketCategoryID
		/// </summary>
		[DataMember(Name = "TicketCategoryID", EmitDefaultValue = false)]
		public int? TicketCategoryID { get; set; }

		/// <summary>
		/// Gets or Sets TicketTypeID
		/// </summary>
		[DataMember(Name = "TicketTypeID", EmitDefaultValue = false)]
		public int? TicketTypeID { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		/// Gets or Sets WorkTypeID
		/// </summary>
		[DataMember(Name = "WorkTypeID", EmitDefaultValue = false)]
		public int? WorkTypeID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public long? SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
