using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ConfigurationItemCategoryModel
	/// </summary>
	[DataContract]
	public partial class ConfigurationItemCategoryModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigurationItemCategoryModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="DisplayColorRGB">DisplayColorRGB.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsClientPortalDefault">IsClientPortalDefault.</param>
		/// <param name="IsGlobalDefault">IsGlobalDefault.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Nickname">Nickname.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ConfigurationItemCategoryModel(long? Id = default, int? DisplayColorRGB = default, bool? IsActive = default, bool? IsClientPortalDefault = default, bool? IsGlobalDefault = default, string Name = default, string Nickname = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.DisplayColorRGB = DisplayColorRGB;
			this.IsActive = IsActive;
			this.IsClientPortalDefault = IsClientPortalDefault;
			this.IsGlobalDefault = IsGlobalDefault;
			this.Name = Name;
			this.Nickname = Nickname;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets DisplayColorRGB
		/// </summary>
		[DataMember(Name = "DisplayColorRGB", EmitDefaultValue = false)]
		public int? DisplayColorRGB { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsClientPortalDefault
		/// </summary>
		[DataMember(Name = "IsClientPortalDefault", EmitDefaultValue = false)]
		public bool? IsClientPortalDefault { get; set; }

		/// <summary>
		/// Gets or Sets IsGlobalDefault
		/// </summary>
		[DataMember(Name = "IsGlobalDefault", EmitDefaultValue = false)]
		public bool? IsGlobalDefault { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets Nickname
		/// </summary>
		[DataMember(Name = "Nickname", EmitDefaultValue = false)]
		public string Nickname { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
