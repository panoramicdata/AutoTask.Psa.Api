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
		/// Initializes a new instance of the <see cref="ClientPortalUserModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ContactID">ContactID.</param>
		/// <param name="DateFormat">DateFormat.</param>
		/// <param name="IsClientPortalActive">IsClientPortalActive.</param>
		/// <param name="NumberFormat">NumberFormat.</param>
		/// <param name="Password">Password.</param>
		/// <param name="SecurityLevel">SecurityLevel.</param>
		/// <param name="TimeFormat">TimeFormat.</param>
		/// <param name="UserName">UserName.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ClientPortalUserModel(long? Id = default, int? ContactID = default, int? DateFormat = default, bool? IsClientPortalActive = default, int? NumberFormat = default, string Password = default, int? SecurityLevel = default, int? TimeFormat = default, string UserName = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ContactID = ContactID;
			this.DateFormat = DateFormat;
			this.IsClientPortalActive = IsClientPortalActive;
			this.NumberFormat = NumberFormat;
			this.Password = Password;
			this.SecurityLevel = SecurityLevel;
			this.TimeFormat = TimeFormat;
			this.UserName = UserName;
			this.UserDefinedFields = UserDefinedFields;
		}

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
