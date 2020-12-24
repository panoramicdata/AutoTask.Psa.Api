using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// TaxModel
	/// </summary>
	[DataContract]
	public partial class TaxModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="TaxModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="IsCompounded">IsCompounded.</param>
		/// <param name="TaxCategoryID">TaxCategoryID.</param>
		/// <param name="TaxName">TaxName.</param>
		/// <param name="TaxRate">TaxRate.</param>
		/// <param name="TaxRegionID">TaxRegionID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public TaxModel(long? Id = default, bool? IsCompounded = default, int? TaxCategoryID = default, string TaxName = default, double? TaxRate = default, int? TaxRegionID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.IsCompounded = IsCompounded;
			this.TaxCategoryID = TaxCategoryID;
			this.TaxName = TaxName;
			this.TaxRate = TaxRate;
			this.TaxRegionID = TaxRegionID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets IsCompounded
		/// </summary>
		[DataMember(Name = "IsCompounded", EmitDefaultValue = false)]
		public bool? IsCompounded { get; set; }

		/// <summary>
		/// Gets or Sets TaxCategoryID
		/// </summary>
		[DataMember(Name = "TaxCategoryID", EmitDefaultValue = false)]
		public int? TaxCategoryID { get; set; }

		/// <summary>
		/// Gets or Sets TaxName
		/// </summary>
		[DataMember(Name = "TaxName", EmitDefaultValue = false)]
		public string TaxName { get; set; }

		/// <summary>
		/// Gets or Sets TaxRate
		/// </summary>
		[DataMember(Name = "TaxRate", EmitDefaultValue = false)]
		public double? TaxRate { get; set; }

		/// <summary>
		/// Gets or Sets TaxRegionID
		/// </summary>
		[DataMember(Name = "TaxRegionID", EmitDefaultValue = false)]
		public int? TaxRegionID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
