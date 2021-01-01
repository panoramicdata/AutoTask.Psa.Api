using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ServiceCallModel
	/// </summary>
	[DataContract]
	public partial class ServiceCallModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CancelationNoticeHours
		/// </summary>
		[DataMember(Name = "CancelationNoticeHours", EmitDefaultValue = false)]
		public double? CancelationNoticeHours { get; set; }

		/// <summary>
		/// Gets or Sets CanceledByResourceID
		/// </summary>
		[DataMember(Name = "CanceledByResourceID", EmitDefaultValue = false)]
		public int? CanceledByResourceID { get; set; }

		/// <summary>
		/// Gets or Sets CanceledDateTime
		/// </summary>
		[DataMember(Name = "CanceledDateTime", EmitDefaultValue = false)]
		public DateTime? CanceledDateTime { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets CompanyLocationID
		/// </summary>
		[DataMember(Name = "CompanyLocationID", EmitDefaultValue = false)]
		public int? CompanyLocationID { get; set; }

		/// <summary>
		/// Gets or Sets CreateDateTime
		/// </summary>
		[DataMember(Name = "CreateDateTime", EmitDefaultValue = false)]
		public DateTime? CreateDateTime { get; set; }

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
		/// Gets or Sets Duration
		/// </summary>
		[DataMember(Name = "Duration", EmitDefaultValue = false)]
		public double? Duration { get; set; }

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
		/// Gets or Sets IsComplete
		/// </summary>
		[DataMember(Name = "IsComplete", EmitDefaultValue = false)]
		public int? IsComplete { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedDateTime
		/// </summary>
		[DataMember(Name = "LastModifiedDateTime", EmitDefaultValue = false)]
		public DateTime? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets StartDateTime
		/// </summary>
		[DataMember(Name = "StartDateTime", EmitDefaultValue = false)]
		public DateTime? StartDateTime { get; set; }

		/// <summary>
		/// Gets or Sets Status
		/// </summary>
		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int? Status { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
