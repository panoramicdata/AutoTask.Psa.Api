using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// PurchaseApprovalModel
	/// </summary>
	[DataContract]
	public partial class PurchaseApprovalModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CostType
		/// </summary>
		[DataMember(Name = "CostType", EmitDefaultValue = false)]
		public string CostType { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets IsApproved
		/// </summary>
		[DataMember(Name = "IsApproved", EmitDefaultValue = false)]
		public bool? IsApproved { get; set; }

		/// <summary>
		/// Gets or Sets RejectNote
		/// </summary>
		[DataMember(Name = "RejectNote", EmitDefaultValue = false)]
		public string RejectNote { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
