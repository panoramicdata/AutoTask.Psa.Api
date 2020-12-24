using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// PurchaseOrderItemReceivingModel
	/// </summary>
	[DataContract]
	public partial class PurchaseOrderItemReceivingModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PurchaseOrderItemReceivingModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="PurchaseOrderItemID">PurchaseOrderItemID.</param>
		/// <param name="QuantityBackOrdered">QuantityBackOrdered.</param>
		/// <param name="QuantityNowReceiving">QuantityNowReceiving.</param>
		/// <param name="QuantityPreviouslyReceived">QuantityPreviouslyReceived.</param>
		/// <param name="ReceiveDate">ReceiveDate.</param>
		/// <param name="ReceivedByResourceID">ReceivedByResourceID.</param>
		/// <param name="SerialNumber">SerialNumber.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public PurchaseOrderItemReceivingModel(long? Id = default, long? PurchaseOrderItemID = default, int? QuantityBackOrdered = default, int? QuantityNowReceiving = default, int? QuantityPreviouslyReceived = default, DateTime? ReceiveDate = default, int? ReceivedByResourceID = default, string SerialNumber = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.PurchaseOrderItemID = PurchaseOrderItemID;
			this.QuantityBackOrdered = QuantityBackOrdered;
			this.QuantityNowReceiving = QuantityNowReceiving;
			this.QuantityPreviouslyReceived = QuantityPreviouslyReceived;
			this.ReceiveDate = ReceiveDate;
			this.ReceivedByResourceID = ReceivedByResourceID;
			this.SerialNumber = SerialNumber;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderItemID
		/// </summary>
		[DataMember(Name = "PurchaseOrderItemID", EmitDefaultValue = false)]
		public long? PurchaseOrderItemID { get; set; }

		/// <summary>
		/// Gets or Sets QuantityBackOrdered
		/// </summary>
		[DataMember(Name = "QuantityBackOrdered", EmitDefaultValue = false)]
		public int? QuantityBackOrdered { get; set; }

		/// <summary>
		/// Gets or Sets QuantityNowReceiving
		/// </summary>
		[DataMember(Name = "QuantityNowReceiving", EmitDefaultValue = false)]
		public int? QuantityNowReceiving { get; set; }

		/// <summary>
		/// Gets or Sets QuantityPreviouslyReceived
		/// </summary>
		[DataMember(Name = "QuantityPreviouslyReceived", EmitDefaultValue = false)]
		public int? QuantityPreviouslyReceived { get; set; }

		/// <summary>
		/// Gets or Sets ReceiveDate
		/// </summary>
		[DataMember(Name = "ReceiveDate", EmitDefaultValue = false)]
		public DateTime? ReceiveDate { get; set; }

		/// <summary>
		/// Gets or Sets ReceivedByResourceID
		/// </summary>
		[DataMember(Name = "ReceivedByResourceID", EmitDefaultValue = false)]
		public int? ReceivedByResourceID { get; set; }

		/// <summary>
		/// Gets or Sets SerialNumber
		/// </summary>
		[DataMember(Name = "SerialNumber", EmitDefaultValue = false)]
		public string SerialNumber { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncPurchaseOrderReceiveInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
