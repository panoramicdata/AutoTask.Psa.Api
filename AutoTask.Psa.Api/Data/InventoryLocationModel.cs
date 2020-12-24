using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// InventoryLocationModel
	/// </summary>
	[DataContract]
	public partial class InventoryLocationModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryLocationModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ImpersonatorCreatorResourceID">ImpersonatorCreatorResourceID.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsDefault">IsDefault.</param>
		/// <param name="LocationName">LocationName.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public InventoryLocationModel(long? Id = default, int? ImpersonatorCreatorResourceID = default, bool? IsActive = default, bool? IsDefault = default, string LocationName = default, int? ResourceID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ImpersonatorCreatorResourceID = ImpersonatorCreatorResourceID;
			this.IsActive = IsActive;
			this.IsDefault = IsDefault;
			this.LocationName = LocationName;
			this.ResourceID = ResourceID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ImpersonatorCreatorResourceID
		/// </summary>
		[DataMember(Name = "ImpersonatorCreatorResourceID", EmitDefaultValue = false)]
		public int? ImpersonatorCreatorResourceID { get; set; }

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
		/// Gets or Sets LocationName
		/// </summary>
		[DataMember(Name = "LocationName", EmitDefaultValue = false)]
		public string LocationName { get; set; }

		/// <summary>
		/// Gets or Sets ResourceID
		/// </summary>
		[DataMember(Name = "ResourceID", EmitDefaultValue = false)]
		public int? ResourceID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
