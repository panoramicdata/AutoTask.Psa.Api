using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ProductTierModel
	/// </summary>
	[DataContract]
	public partial class ProductTierModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ProductTierModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ProductID">ProductID.</param>
		/// <param name="UnitCost">UnitCost.</param>
		/// <param name="UnitPrice">UnitPrice.</param>
		/// <param name="UpToUnitCount">UpToUnitCount.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ProductTierModel(long? Id = default, int? ProductID = default, double? UnitCost = default, double? UnitPrice = default, double? UpToUnitCount = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ProductID = ProductID;
			this.UnitCost = UnitCost;
			this.UnitPrice = UnitPrice;
			this.UpToUnitCount = UpToUnitCount;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ProductID
		/// </summary>
		[DataMember(Name = "ProductID", EmitDefaultValue = false)]
		public int? ProductID { get; set; }

		/// <summary>
		/// Gets or Sets UnitCost
		/// </summary>
		[DataMember(Name = "UnitCost", EmitDefaultValue = false)]
		public double? UnitCost { get; set; }

		/// <summary>
		/// Gets or Sets UnitPrice
		/// </summary>
		[DataMember(Name = "UnitPrice", EmitDefaultValue = false)]
		public double? UnitPrice { get; set; }

		/// <summary>
		/// Gets or Sets UpToUnitCount
		/// </summary>
		[DataMember(Name = "UpToUnitCount", EmitDefaultValue = false)]
		public double? UpToUnitCount { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncProductTierInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
