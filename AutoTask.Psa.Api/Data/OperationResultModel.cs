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
		/// Initializes a new instance of the <see cref="OperationResultModel" /> class.
		/// </summary>
		/// <param name="ItemId">ItemId.</param>
		public OperationResultModel(Object ItemId = default)
		{
			this.ItemId = ItemId;
		}

		/// <summary>
		/// Gets or Sets ItemId
		/// </summary>
		[DataMember(Name = "ItemId", EmitDefaultValue = false)]
		public Object ItemId { get; set; }
	}
}
