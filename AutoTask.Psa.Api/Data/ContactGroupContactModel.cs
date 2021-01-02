using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContactGroupContactModel
	/// </summary>
	[DataContract]
	public partial class ContactGroupContactModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ContactId
		/// </summary>
		[DataMember(Name = "ContactId", EmitDefaultValue = false)]
		public int? ContactId { get; set; }

		/// <summary>
		/// Gets or Sets ContactGroupId
		/// </summary>
		[DataMember(Name = "ContactGroupId", EmitDefaultValue = false)]
		public int? ContactGroupId { get; set; }

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
