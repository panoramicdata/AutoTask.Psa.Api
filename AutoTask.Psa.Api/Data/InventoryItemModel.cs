using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// InventoryItemModel
	/// </summary>
	[DataContract]
	public partial class InventoryItemModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryItemModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BackOrderQuantity">BackOrderQuantity.</param>
		/// <param name="Bin">Bin.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="InventoryLocationID">InventoryLocationID.</param>
		/// <param name="ProductID">ProductID.</param>
		/// <param name="QuantityMaximum">QuantityMaximum.</param>
		/// <param name="QuantityMinimum">QuantityMinimum.</param>
		/// <param name="QuantityOnHand">QuantityOnHand.</param>
		/// <param name="QuantityOnOrder">QuantityOnOrder.</param>
		/// <param name="QuantityPicked">QuantityPicked.</param>
		/// <param name="QuantityReserved">QuantityReserved.</param>
		/// <param name="ReferenceNumber">ReferenceNumber.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public InventoryItemModel(long? Id = default, int? BackOrderQuantity = default, string Bin = default, int? ImpersonatorCreatorResourceID = default, int? InventoryLocationID = default, int? ProductID = default, int? QuantityMaximum = default, int? QuantityMinimum = default, int? QuantityOnHand = default, int? QuantityOnOrder = default, int? QuantityPicked = default, int? QuantityReserved = default, string ReferenceNumber = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BackOrderQuantity = BackOrderQuantity;
			this.Bin = Bin;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.InventoryLocationID = InventoryLocationID;
			this.ProductID = ProductID;
			this.QuantityMaximum = QuantityMaximum;
			this.QuantityMinimum = QuantityMinimum;
			this.QuantityOnHand = QuantityOnHand;
			this.QuantityOnOrder = QuantityOnOrder;
			this.QuantityPicked = QuantityPicked;
			this.QuantityReserved = QuantityReserved;
			this.ReferenceNumber = ReferenceNumber;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BackOrderQuantity
		/// </summary>
		[DataMember(Name = "BackOrderQuantity", EmitDefaultValue = false)]
		public int? BackOrderQuantity { get; set; }

		/// <summary>
		/// Gets or Sets Bin
		/// </summary>
		[DataMember(Name = "Bin", EmitDefaultValue = false)]
		public string Bin { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets InventoryLocationID
		/// </summary>
		[DataMember(Name = "InventoryLocationID", EmitDefaultValue = false)]
		public int? InventoryLocationID { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public int? ProductID { get; set; }

		/// <summary>
		/// Gets or Sets QuantityMaximum
		/// </summary>
		[DataMember(Name = "QuantityMaximum", EmitDefaultValue = false)]
		public int? QuantityMaximum { get; set; }

		/// <summary>
		/// Gets or Sets QuantityMinimum
		/// </summary>
		[DataMember(Name = "QuantityMinimum", EmitDefaultValue = false)]
		public int? QuantityMinimum { get; set; }

		/// <summary>
		/// Gets or Sets QuantityOnHand
		/// </summary>
		[DataMember(Name = "QuantityOnHand", EmitDefaultValue = false)]
		public int? QuantityOnHand { get; set; }

		/// <summary>
		/// Gets or Sets QuantityOnOrder
		/// </summary>
		[DataMember(Name = "QuantityOnOrder", EmitDefaultValue = false)]
		public int? QuantityOnOrder { get; set; }

		/// <summary>
		/// Gets or Sets QuantityPicked
		/// </summary>
		[DataMember(Name = "QuantityPicked", EmitDefaultValue = false)]
		public int? QuantityPicked { get; set; }

		/// <summary>
		/// Gets or Sets QuantityReserved
		/// </summary>
		[DataMember(Name = "QuantityReserved", EmitDefaultValue = false)]
		public int? QuantityReserved { get; set; }

		/// <summary>
		/// Gets or Sets ReferenceNumber
		/// </summary>
		[DataMember(Name = "ReferenceNumber", EmitDefaultValue = false)]
		public string ReferenceNumber { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
