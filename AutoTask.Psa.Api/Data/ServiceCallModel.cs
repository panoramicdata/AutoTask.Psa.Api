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
		/// Initializes a new instance of the <see cref="ServiceCallModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CancelationNoticeHours">CancelationNoticeHours.</param>
		/// <param name="CanceledByResourceID">CanceledByResourceID.</param>
		/// <param name="CanceledDateTime">CanceledDateTime.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="CompanyLocationID">CompanyLocationID.</param>
		/// <param name="CreateDateTime">CreateDateTime.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Duration">Duration.</param>
		/// <param name="EndDateTime">EndDateTime.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="IsComplete">IsComplete.</param>
		/// <param name="LastModifiedDateTime">LastModifiedDateTime.</param>
		/// <param name="StartDateTime">StartDateTime.</param>
		/// <param name="Status">Status.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ServiceCallModel(long? Id = default, double? CancelationNoticeHours = default, int? CanceledByResourceID = default, DateTime? CanceledDateTime = default, int? CompanyID = default, int? CompanyLocationID = default, DateTime? CreateDateTime = default, int? CreatorResourceID = default, string Description = default, double? Duration = default, DateTime? EndDateTime = default, int? ImpersonatorCreatorResourceID = default, int? IsComplete = default, DateTime? LastModifiedDateTime = default, DateTime? StartDateTime = default, int? Status = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CancelationNoticeHours = CancelationNoticeHours;
			this.CanceledByResourceID = CanceledByResourceID;
			this.CanceledDateTime = CanceledDateTime;
			this.CompanyID = CompanyID;
			this.CompanyLocationID = CompanyLocationID;
			this.CreateDateTime = CreateDateTime;
			this.CreatorResourceID = CreatorResourceID;
			this.Description = Description;
			this.Duration = Duration;
			this.EndDateTime = EndDateTime;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.IsComplete = IsComplete;
			this.LastModifiedDateTime = LastModifiedDateTime;
			this.StartDateTime = StartDateTime;
			this.Status = Status;
			this.UserDefinedFields = UserDefinedFields;
		}

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
