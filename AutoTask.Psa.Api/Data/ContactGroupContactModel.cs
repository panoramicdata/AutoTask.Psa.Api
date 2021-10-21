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
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ContactId
		/// </summary>
		[DataMember(Name = "ContactId")]
		public int? ContactId { get; set; }

		/// <summary>
		/// Gets or Sets ContactGroupId
		/// </summary>
		[DataMember(Name = "ContactGroupId")]
		public int? ContactGroupId { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId")]
		public ExpressionFunc? SoapParentPropertyId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
