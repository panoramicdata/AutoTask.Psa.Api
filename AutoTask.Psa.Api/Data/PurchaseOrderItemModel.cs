using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// PurchaseOrderItemModel
	/// </summary>
	[DataContract]
	public partial class PurchaseOrderItemModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ChargeID
		/// </summary>
		[DataMember(Name = "ChargeID", EmitDefaultValue = false)]
		public int? ChargeID { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public long? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets EstimatedArrivalDate
		/// </summary>
		[DataMember(Name = "EstimatedArrivalDate", EmitDefaultValue = false)]
		public DateTime? EstimatedArrivalDate { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyUnitCost
		/// </summary>
		[DataMember(Name = "InternalCurrencyUnitCost", EmitDefaultValue = false)]
		public double? InternalCurrencyUnitCost { get; set; }

		/// <summary>
		/// Gets or Sets InventoryLocationID
		/// </summary>
		[DataMember(Name = "InventoryLocationID", EmitDefaultValue = false)]
		public int? InventoryLocationID { get; set; }

		/// <summary>
		/// Gets or Sets Memo
		/// </summary>
		[DataMember(Name = "Memo", EmitDefaultValue = false)]
		public string Memo { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets OrderID
		/// </summary>
		[DataMember(Name = "OrderID", EmitDefaultValue = false)]
		public int? OrderID { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public int? ProductID { get; set; }

		/// <summary>
		/// Gets or Sets ProjectID
		/// </summary>
		[DataMember(Name = "ProjectID", EmitDefaultValue = false)]
		public long? ProjectID { get; set; }

		/// <summary>
		/// Gets or Sets Quantity
		/// </summary>
		[DataMember(Name = "Quantity", EmitDefaultValue = false)]
		public int? Quantity { get; set; }

		/// <summary>
		/// Gets or Sets SalesOrderID
		/// </summary>
		[DataMember(Name = "SalesOrderID", EmitDefaultValue = false)]
		public long? SalesOrderID { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public long? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets UnitCost
		/// </summary>
		[DataMember(Name = "UnitCost", EmitDefaultValue = false)]
		public double? UnitCost { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
