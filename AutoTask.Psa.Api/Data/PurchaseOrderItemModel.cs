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
		/// Initializes a new instance of the <see cref="PurchaseOrderItemModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ChargeID">ChargeID.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="EstimatedArrivalDate">EstimatedArrivalDate.</param>
		/// <param name="InternalCurrencyUnitCost">InternalCurrencyUnitCost.</param>
		/// <param name="InventoryLocationID">InventoryLocationID.</param>
		/// <param name="Memo">Memo.</param>
		/// <param name="OrderID">OrderID.</param>
		/// <param name="ProductID">ProductID.</param>
		/// <param name="ProjectID">ProjectID.</param>
		/// <param name="Quantity">Quantity.</param>
		/// <param name="SalesOrderID">SalesOrderID.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="UnitCost">UnitCost.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public PurchaseOrderItemModel(long? Id = default, int? ChargeID = default, long? ContractID = default, DateTime? EstimatedArrivalDate = default, double? InternalCurrencyUnitCost = default, int? InventoryLocationID = default, string Memo = default, int? OrderID = default, int? ProductID = default, long? ProjectID = default, int? Quantity = default, long? SalesOrderID = default, long? TicketID = default, double? UnitCost = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ChargeID = ChargeID;
			this.ContractID = ContractID;
			this.EstimatedArrivalDate = EstimatedArrivalDate;
			this.InternalCurrencyUnitCost = InternalCurrencyUnitCost;
			this.InventoryLocationID = InventoryLocationID;
			this.Memo = Memo;
			this.OrderID = OrderID;
			this.ProductID = ProductID;
			this.ProjectID = ProjectID;
			this.Quantity = Quantity;
			this.SalesOrderID = SalesOrderID;
			this.TicketID = TicketID;
			this.UnitCost = UnitCost;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		public string Memo { get; set; }

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
		public ExpressionFuncPurchaseOrderItemInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
