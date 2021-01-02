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
		public string Bin { get; set; } = string.Empty;

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
		public string ReferenceNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
