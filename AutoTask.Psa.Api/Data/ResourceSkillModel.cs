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
		/// Initializes a new instance of the <see cref="ResourceSkillModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="SkillDescription">SkillDescription.</param>
		/// <param name="SkillID">SkillID.</param>
		/// <param name="SkillLevel">SkillLevel.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ResourceSkillModel(long? Id = default, long? ResourceID = default, string SkillDescription = default, long? SkillID = default, long? SkillLevel = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ResourceID = ResourceID;
			this.SkillDescription = SkillDescription;
			this.SkillID = SkillID;
			this.SkillLevel = SkillLevel;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		public string SkillDescription { get; set; }

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
		public ExpressionFuncResourceSkillInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
