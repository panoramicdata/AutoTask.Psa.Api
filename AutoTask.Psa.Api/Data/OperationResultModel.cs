using System;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// OperationResultModel
	/// </summary>
	[DataContract]
	public partial class OperationResultModel
	{
		/// <summary>
		/// Gets or Sets ItemId
		/// </summary>
		[DataMember(Name = "ItemId", EmitDefaultValue = false)]
		public Object ItemId { get; set; }
	}
}
