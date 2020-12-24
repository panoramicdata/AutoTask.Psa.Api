using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// RoleModel
	/// </summary>
	[DataContract]
	public partial class RoleModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RoleModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Description">Description.</param>
		/// <param name="HourlyFactor">HourlyFactor.</param>
		/// <param name="HourlyRate">HourlyRate.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsExcludedFromNewContracts">IsExcludedFromNewContracts.</param>
		/// <param name="IsSystemRole">IsSystemRole.</param>
		/// <param name="Name">Name.</param>
		/// <param name="QuoteItemDefaultTaxCategoryId">QuoteItemDefaultTaxCategoryId.</param>
		/// <param name="RoleType">RoleType.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public RoleModel(long? Id = default, string Description = default, double? HourlyFactor = default, double? HourlyRate = default, bool? IsActive = default, bool? IsExcludedFromNewContracts = default, bool? IsSystemRole = default, string Name = default, int? QuoteItemDefaultTaxCategoryId = default, int? RoleType = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.Description = Description;
			this.HourlyFactor = HourlyFactor;
			this.HourlyRate = HourlyRate;
			this.IsActive = IsActive;
			this.IsExcludedFromNewContracts = IsExcludedFromNewContracts;
			this.IsSystemRole = IsSystemRole;
			this.Name = Name;
			this.QuoteItemDefaultTaxCategoryId = QuoteItemDefaultTaxCategoryId;
			this.RoleType = RoleType;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets HourlyFactor
		/// </summary>
		[DataMember(Name = "HourlyFactor", EmitDefaultValue = false)]
		public double? HourlyFactor { get; set; }

		/// <summary>
		/// Gets or Sets HourlyRate
		/// </summary>
		[DataMember(Name = "HourlyRate", EmitDefaultValue = false)]
		public double? HourlyRate { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsExcludedFromNewContracts
		/// </summary>
		[DataMember(Name = "IsExcludedFromNewContracts", EmitDefaultValue = false)]
		public bool? IsExcludedFromNewContracts { get; set; }

		/// <summary>
		/// Gets or Sets IsSystemRole
		/// </summary>
		[DataMember(Name = "IsSystemRole", EmitDefaultValue = false)]
		public bool? IsSystemRole { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets QuoteItemDefaultTaxCategoryId
		/// </summary>
		[DataMember(Name = "QuoteItemDefaultTaxCategoryId", EmitDefaultValue = false)]
		public int? QuoteItemDefaultTaxCategoryId { get; set; }

		/// <summary>
		/// Gets or Sets RoleType
		/// </summary>
		[DataMember(Name = "RoleType", EmitDefaultValue = false)]
		public int? RoleType { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
