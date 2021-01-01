using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ClientPortalUserModel
	/// </summary>
	[DataContract]
	public partial class ClientPortalUserModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public int? ContactID { get; set; }

		/// <summary>
		/// Gets or Sets DateFormat
		/// </summary>
		[DataMember(Name = "DateFormat", EmitDefaultValue = false)]
		public int? DateFormat { get; set; }

		/// <summary>
		/// Gets or Sets IsClientPortalActive
		/// </summary>
		[DataMember(Name = "IsClientPortalActive", EmitDefaultValue = false)]
		public bool? IsClientPortalActive { get; set; }

		/// <summary>
		/// Gets or Sets NumberFormat
		/// </summary>
		[DataMember(Name = "NumberFormat", EmitDefaultValue = false)]
		public int? NumberFormat { get; set; }

		/// <summary>
		/// Gets or Sets Password
		/// </summary>
		[DataMember(Name = "Password", EmitDefaultValue = false)]
		public string Password { get; set; }

		/// <summary>
		/// Gets or Sets SecurityLevel
		/// </summary>
		[DataMember(Name = "SecurityLevel", EmitDefaultValue = false)]
		public int? SecurityLevel { get; set; }

		/// <summary>
		/// Gets or Sets TimeFormat
		/// </summary>
		[DataMember(Name = "TimeFormat", EmitDefaultValue = false)]
		public int? TimeFormat { get; set; }

		/// <summary>
		/// Gets or Sets UserName
		/// </summary>
		[DataMember(Name = "UserName", EmitDefaultValue = false)]
		public string UserName { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
