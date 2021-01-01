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
