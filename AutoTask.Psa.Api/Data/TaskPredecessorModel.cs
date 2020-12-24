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
		/// Initializes a new instance of the <see cref="TaskPredecessorModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="LagDays">LagDays.</param>
		/// <param name="PredecessorTaskID">PredecessorTaskID.</param>
		/// <param name="SuccessorTaskID">SuccessorTaskID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TaskPredecessorModel(long? Id = default, int? LagDays = default, int? PredecessorTaskID = default, int? SuccessorTaskID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.LagDays = LagDays;
			this.PredecessorTaskID = PredecessorTaskID;
			this.SuccessorTaskID = SuccessorTaskID;
			this.UserDefinedFields = UserDefinedFields;
		}

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
