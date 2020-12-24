using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// BillingItemApprovalLevelModel
	/// </summary>
	[DataContract]
	public partial class BillingItemApprovalLevelModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BillingItemApprovalLevelModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ApprovalDateTime">ApprovalDateTime.</param>
		/// <param name="ApprovalLevel">ApprovalLevel.</param>
		/// <param name="ApprovalResourceID">ApprovalResourceID.</param>
		/// <param name="TimeEntryID">TimeEntryID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public BillingItemApprovalLevelModel(long? Id = default, DateTime? ApprovalDateTime = default, int? ApprovalLevel = default, int? ApprovalResourceID = default, int? TimeEntryID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ApprovalDateTime = ApprovalDateTime;
			this.ApprovalLevel = ApprovalLevel;
			this.ApprovalResourceID = ApprovalResourceID;
			this.TimeEntryID = TimeEntryID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ApprovalDateTime
		/// </summary>
		[DataMember(Name = "ApprovalDateTime", EmitDefaultValue = false)]
		public DateTime? ApprovalDateTime { get; set; }

		/// <summary>
		/// Gets or Sets ApprovalLevel
		/// </summary>
		[DataMember(Name = "ApprovalLevel", EmitDefaultValue = false)]
		public int? ApprovalLevel { get; set; }

		/// <summary>
		/// Gets or Sets ApprovalResourceID
		/// </summary>
		[DataMember(Name = "ApprovalResourceID", EmitDefaultValue = false)]
		public int? ApprovalResourceID { get; set; }

		/// <summary>
		/// Gets or Sets TimeEntryID
		/// </summary>
		[DataMember(Name = "TimeEntryID", EmitDefaultValue = false)]
		public int? TimeEntryID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
