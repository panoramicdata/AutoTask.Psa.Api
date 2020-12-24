using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// QuoteLocationModel
	/// </summary>
	[DataContract]
	public partial class QuoteLocationModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="QuoteLocationModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Address1">Address1.</param>
		/// <param name="Address2">Address2.</param>
		/// <param name="City">City.</param>
		/// <param name="PostalCode">PostalCode.</param>
		/// <param name="State">State.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public QuoteLocationModel(long? Id = default, string Address1 = default, string Address2 = default, string City = default, string PostalCode = default, string State = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.Address1 = Address1;
			this.Address2 = Address2;
			this.City = City;
			this.PostalCode = PostalCode;
			this.State = State;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

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
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
