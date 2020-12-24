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
		/// Initializes a new instance of the <see cref="InventoryTransferModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="FromLocationID">FromLocationID.</param>
		/// <param name="Notes">Notes.</param>
		/// <param name="ProductID">ProductID.</param>
		/// <param name="QuantityTransferred">QuantityTransferred.</param>
		/// <param name="SerialNumber">SerialNumber.</param>
		/// <param name="ToLocationID">ToLocationID.</param>
		/// <param name="TransferByResourceID">TransferByResourceID.</param>
		/// <param name="TransferDate">TransferDate.</param>
		/// <param name="UpdateNote">UpdateNote.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public InventoryTransferModel(long? Id = default, long? FromLocationID = default, string Notes = default, long? ProductID = default, int? QuantityTransferred = default, string SerialNumber = default, long? ToLocationID = default, int? TransferByResourceID = default, DateTime? TransferDate = default, string UpdateNote = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.FromLocationID = FromLocationID;
			this.Notes = Notes;
			this.ProductID = ProductID;
			this.QuantityTransferred = QuantityTransferred;
			this.SerialNumber = SerialNumber;
			this.ToLocationID = ToLocationID;
			this.TransferByResourceID = TransferByResourceID;
			this.TransferDate = TransferDate;
			this.UpdateNote = UpdateNote;
			this.UserDefinedFields = UserDefinedFields;
		}

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
