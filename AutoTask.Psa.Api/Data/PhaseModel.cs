using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// PhaseModel
	/// </summary>
	[DataContract]
	public partial class PhaseModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PhaseModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CreateDate">CreateDate.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="DueDate">DueDate.</param>
		/// <param name="EstimatedHours">EstimatedHours.</param>
		/// <param name="ExternalID">ExternalID.</param>
		/// <param name="IsScheduled">IsScheduled.</param>
		/// <param name="LastActivityDateTime">LastActivityDateTime.</param>
		/// <param name="ParentPhaseID">ParentPhaseID.</param>
		/// <param name="PhaseNumber">PhaseNumber.</param>
		/// <param name="ProjectID">ProjectID.</param>
		/// <param name="StartDate">StartDate.</param>
		/// <param name="Title">Title.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public PhaseModel(long? Id = default, DateTime? CreateDate = default, int? CreatorResourceID = default, string Description = default, DateTime? DueDate = default, double? EstimatedHours = default, string ExternalID = default, bool? IsScheduled = default, DateTime? LastActivityDateTime = default, int? ParentPhaseID = default, string PhaseNumber = default, int? ProjectID = default, DateTime? StartDate = default, string Title = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CreateDate = CreateDate;
			this.CreatorResourceID = CreatorResourceID;
			this.Description = Description;
			this.DueDate = DueDate;
			this.EstimatedHours = EstimatedHours;
			this.ExternalID = ExternalID;
			this.IsScheduled = IsScheduled;
			this.LastActivityDateTime = LastActivityDateTime;
			this.ParentPhaseID = ParentPhaseID;
			this.PhaseNumber = PhaseNumber;
			this.ProjectID = ProjectID;
			this.StartDate = StartDate;
			this.Title = Title;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

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
		/// Gets or Sets DueDate
		/// </summary>
		[DataMember(Name = "DueDate", EmitDefaultValue = false)]
		public DateTime? DueDate { get; set; }

		/// <summary>
		/// Gets or Sets EstimatedHours
		/// </summary>
		[DataMember(Name = "EstimatedHours", EmitDefaultValue = false)]
		public double? EstimatedHours { get; set; }

		/// <summary>
		/// Gets or Sets ExternalID
		/// </summary>
		[DataMember(Name = "ExternalID", EmitDefaultValue = false)]
		public string ExternalID { get; set; }

		/// <summary>
		/// Gets or Sets IsScheduled
		/// </summary>
		[DataMember(Name = "IsScheduled", EmitDefaultValue = false)]
		public bool? IsScheduled { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityDateTime
		/// </summary>
		[DataMember(Name = "LastActivityDateTime", EmitDefaultValue = false)]
		public DateTime? LastActivityDateTime { get; set; }

		/// <summary>
		/// Gets or Sets ParentPhaseID
		/// </summary>
		[DataMember(Name = "ParentPhaseID", EmitDefaultValue = false)]
		public int? ParentPhaseID { get; set; }

		/// <summary>
		/// Gets or Sets PhaseNumber
		/// </summary>
		[DataMember(Name = "PhaseNumber", EmitDefaultValue = false)]
		public string PhaseNumber { get; set; }

		/// <summary>
		/// Gets or Sets ProjectID
		/// </summary>
		[DataMember(Name = "ProjectID", EmitDefaultValue = false)]
		public int? ProjectID { get; set; }

		/// <summary>
		/// Gets or Sets StartDate
		/// </summary>
		[DataMember(Name = "StartDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncPhaseInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
