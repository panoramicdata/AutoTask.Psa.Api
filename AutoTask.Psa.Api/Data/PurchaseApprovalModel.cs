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
		/// Initializes a new instance of the <see cref="PurchaseApprovalModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CostType">CostType.</param>
		/// <param name="IsApproved">IsApproved.</param>
		/// <param name="RejectNote">RejectNote.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public PurchaseApprovalModel(long? Id = default, string CostType = default, bool? IsApproved = default, string RejectNote = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CostType = CostType;
			this.IsApproved = IsApproved;
			this.RejectNote = RejectNote;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CostType
		/// </summary>
		[DataMember(Name = "CostType", EmitDefaultValue = false)]
		public string CostType { get; set; }

		/// <summary>
		/// Gets or Sets IsApproved
		/// </summary>
		[DataMember(Name = "IsApproved", EmitDefaultValue = false)]
		public bool? IsApproved { get; set; }

		/// <summary>
		/// Gets or Sets RejectNote
		/// </summary>
		[DataMember(Name = "RejectNote", EmitDefaultValue = false)]
		public string RejectNote { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
