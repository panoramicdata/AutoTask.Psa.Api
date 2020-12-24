using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// InternalLocationModel
	/// </summary>
	[DataContract]
	public partial class InternalLocationModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="InternalLocationModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AdditionalAddressInfo">AdditionalAddressInfo.</param>
		/// <param name="Address1">Address1.</param>
		/// <param name="Address2">Address2.</param>
		/// <param name="City">City.</param>
		/// <param name="Country">Country.</param>
		/// <param name="HolidaySetId">HolidaySetId.</param>
		/// <param name="IsDefault">IsDefault.</param>
		/// <param name="Name">Name.</param>
		/// <param name="PostalCode">PostalCode.</param>
		/// <param name="State">State.</param>
		/// <param name="TimeZone">TimeZone.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public InternalLocationModel(long? Id = default, string AdditionalAddressInfo = default, string Address1 = default, string Address2 = default, string City = default, string Country = default, long? HolidaySetId = default, bool? IsDefault = default, string Name = default, string PostalCode = default, string State = default, string TimeZone = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AdditionalAddressInfo = AdditionalAddressInfo;
			this.Address1 = Address1;
			this.Address2 = Address2;
			this.City = City;
			this.Country = Country;
			this.HolidaySetId = HolidaySetId;
			this.IsDefault = IsDefault;
			this.Name = Name;
			this.PostalCode = PostalCode;
			this.State = State;
			this.TimeZone = TimeZone;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AdditionalAddressInfo
		/// </summary>
		[DataMember(Name = "AdditionalAddressInfo", EmitDefaultValue = false)]
		public string AdditionalAddressInfo { get; set; }

		/// <summary>
		/// Gets or Sets Address1
		/// </summary>
		[DataMember(Name = "Address1", EmitDefaultValue = false)]
		public string Address1 { get; set; }

		/// <summary>
		/// Gets or Sets Address2
		/// </summary>
		[DataMember(Name = "Address2", EmitDefaultValue = false)]
		public string Address2 { get; set; }

		/// <summary>
		/// Gets or Sets City
		/// </summary>
		[DataMember(Name = "City", EmitDefaultValue = false)]
		public string City { get; set; }

		/// <summary>
		/// Gets or Sets Country
		/// </summary>
		[DataMember(Name = "Country", EmitDefaultValue = false)]
		public string Country { get; set; }

		/// <summary>
		/// Gets or Sets HolidaySetId
		/// </summary>
		[DataMember(Name = "HolidaySetId", EmitDefaultValue = false)]
		public long? HolidaySetId { get; set; }

		/// <summary>
		/// Gets or Sets IsDefault
		/// </summary>
		[DataMember(Name = "IsDefault", EmitDefaultValue = false)]
		public bool? IsDefault { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets PostalCode
		/// </summary>
		[DataMember(Name = "PostalCode", EmitDefaultValue = false)]
		public string PostalCode { get; set; }

		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "State", EmitDefaultValue = false)]
		public string State { get; set; }

		/// <summary>
		/// Gets or Sets TimeZone
		/// </summary>
		[DataMember(Name = "TimeZone", EmitDefaultValue = false)]
		public string TimeZone { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
