using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ProductVendorModel
	/// </summary>
	[DataContract]
	public partial class ProductVendorModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProductVendorModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsDefault">IsDefault.</param>
		/// <param name="ProductID">ProductID.</param>
		/// <param name="VendorCost">VendorCost.</param>
		/// <param name="VendorID">VendorID.</param>
		/// <param name="VendorPartNumber">VendorPartNumber.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ProductVendorModel(long? Id = default, bool? IsActive = default, bool? IsDefault = default, int? ProductID = default, double? VendorCost = default, int? VendorID = default, string VendorPartNumber = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.IsActive = IsActive;
			this.IsDefault = IsDefault;
			this.ProductID = ProductID;
			this.VendorCost = VendorCost;
			this.VendorID = VendorID;
			this.VendorPartNumber = VendorPartNumber;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsDefault
		/// </summary>
		[DataMember(Name = "IsDefault", EmitDefaultValue = false)]
		public bool? IsDefault { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public int? ProductID { get; set; }

		/// <summary>
		/// Gets or Sets VendorCost
		/// </summary>
		[DataMember(Name = "VendorCost", EmitDefaultValue = false)]
		public double? VendorCost { get; set; }

		/// <summary>
		/// Gets or Sets VendorID
		/// </summary>
		[DataMember(Name = "VendorID", EmitDefaultValue = false)]
		public int? VendorID { get; set; }

		/// <summary>
		/// Gets or Sets VendorPartNumber
		/// </summary>
		[DataMember(Name = "VendorPartNumber", EmitDefaultValue = false)]
		public string VendorPartNumber { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncProductVendorInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
