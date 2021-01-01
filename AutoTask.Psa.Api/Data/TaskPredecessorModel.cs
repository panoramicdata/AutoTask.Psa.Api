using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TaskPredecessorModel
	/// </summary>
	[DataContract]
	public partial class TaskPredecessorModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets LagDays
		/// </summary>
		[DataMember(Name = "LagDays", EmitDefaultValue = false)]
		public int? LagDays { get; set; }

		/// <summary>
		/// Gets or Sets PredecessorTaskID
		/// </summary>
		[DataMember(Name = "PredecessorTaskID", EmitDefaultValue = false)]
		public int? PredecessorTaskID { get; set; }

		/// <summary>
		/// Gets or Sets SuccessorTaskID
		/// </summary>
		[DataMember(Name = "SuccessorTaskID", EmitDefaultValue = false)]
		public int? SuccessorTaskID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncTaskPredecessorInt64 SoapParentPropertyId { get; private set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
