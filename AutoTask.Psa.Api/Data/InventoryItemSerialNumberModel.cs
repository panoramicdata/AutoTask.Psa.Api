using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// InventoryItemSerialNumberModel
	/// </summary>
	[DataContract]
	public partial class InventoryItemSerialNumberModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryItemSerialNumberModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="InventoryItemID">InventoryItemID.</param>
		/// <param name="SerialNumber">SerialNumber.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public InventoryItemSerialNumberModel(long? Id = default, long? InventoryItemID = default, string SerialNumber = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.InventoryItemID = InventoryItemID;
			this.SerialNumber = SerialNumber;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets InventoryItemID
		/// </summary>
		[DataMember(Name = "InventoryItemID", EmitDefaultValue = false)]
		public long? InventoryItemID { get; set; }

		/// <summary>
		/// Gets or Sets SerialNumber
		/// </summary>
		[DataMember(Name = "SerialNumber", EmitDefaultValue = false)]
		public string SerialNumber { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncInventoryItemSerialNumberInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
