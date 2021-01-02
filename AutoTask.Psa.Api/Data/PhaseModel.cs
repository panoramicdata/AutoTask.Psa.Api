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
		public string Description { get; set; } = string.Empty;

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
		public string ExternalID { get; set; } = string.Empty;

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
		public string PhaseNumber { get; set; } = string.Empty;

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
		public string Title { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
