using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// InventoryTransferModel
	/// </summary>
	[DataContract]
	public partial class InventoryTransferModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets FromLocationID
		/// </summary>
		[DataMember(Name = "FromLocationID", EmitDefaultValue = false)]
		public long? FromLocationID { get; set; }

		/// <summary>
		/// Gets or Sets Notes
		/// </summary>
		[DataMember(Name = "Notes", EmitDefaultValue = false)]
		public string Notes { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public long? ProductID { get; set; }

		/// <summary>
		/// Gets or Sets QuantityTransferred
		/// </summary>
		[DataMember(Name = "QuantityTransferred", EmitDefaultValue = false)]
		public int? QuantityTransferred { get; set; }

		/// <summary>
		/// Gets or Sets SerialNumber
		/// </summary>
		[DataMember(Name = "SerialNumber", EmitDefaultValue = false)]
		public string SerialNumber { get; set; }

		/// <summary>
		/// Gets or Sets ToLocationID
		/// </summary>
		[DataMember(Name = "ToLocationID", EmitDefaultValue = false)]
		public long? ToLocationID { get; set; }

		/// <summary>
		/// Gets or Sets TransferByResourceID
		/// </summary>
		[DataMember(Name = "TransferByResourceID", EmitDefaultValue = false)]
		public int? TransferByResourceID { get; set; }

		/// <summary>
		/// Gets or Sets TransferDate
		/// </summary>
		[DataMember(Name = "TransferDate", EmitDefaultValue = false)]
		public DateTime? TransferDate { get; set; }

		/// <summary>
		/// Gets or Sets UpdateNote
		/// </summary>
		[DataMember(Name = "UpdateNote", EmitDefaultValue = false)]
		public string UpdateNote { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
