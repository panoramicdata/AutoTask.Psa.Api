using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ResourceSkillModel
	/// </summary>
	[DataContract]
	public partial class ResourceSkillModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ResourceID
		/// </summary>
		[DataMember(Name = "ResourceID", EmitDefaultValue = false)]
		public long? ResourceID { get; set; }

		/// <summary>
		/// Gets or Sets SkillDescription
		/// </summary>
		[DataMember(Name = "SkillDescription", EmitDefaultValue = false)]
		public string SkillDescription { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets SkillID
		/// </summary>
		[DataMember(Name = "SkillID", EmitDefaultValue = false)]
		public long? SkillID { get; set; }

		/// <summary>
		/// Gets or Sets SkillLevel
		/// </summary>
		[DataMember(Name = "SkillLevel", EmitDefaultValue = false)]
		public long? SkillLevel { get; set; }

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
