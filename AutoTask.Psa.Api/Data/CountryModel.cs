using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CountryModel
	/// </summary>
	[DataContract]
	public partial class CountryModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CountryModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="AddressFormatID">AddressFormatID.</param>
		/// <param name="CountryCode">CountryCode.</param>
		/// <param name="DisplayName">DisplayName.</param>
		/// <param name="InvoiceTemplateID">InvoiceTemplateID.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsDefaultCountry">IsDefaultCountry.</param>
		/// <param name="Name">Name.</param>
		/// <param name="QuoteTemplateID">QuoteTemplateID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public CountryModel(long? Id = default, long? AddressFormatID = default, string CountryCode = default, string DisplayName = default, int? InvoiceTemplateID = default, bool? IsActive = default, bool? IsDefaultCountry = default, string Name = default, int? QuoteTemplateID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.AddressFormatID = AddressFormatID;
			this.CountryCode = CountryCode;
			this.DisplayName = DisplayName;
			this.InvoiceTemplateID = InvoiceTemplateID;
			this.IsActive = IsActive;
			this.IsDefaultCountry = IsDefaultCountry;
			this.Name = Name;
			this.QuoteTemplateID = QuoteTemplateID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets AddressFormatID
		/// </summary>
		[DataMember(Name = "AddressFormatID", EmitDefaultValue = false)]
		public long? AddressFormatID { get; set; }

		/// <summary>
		/// Gets or Sets CountryCode
		/// </summary>
		[DataMember(Name = "CountryCode", EmitDefaultValue = false)]
		public string CountryCode { get; set; }

		/// <summary>
		/// Gets or Sets DisplayName
		/// </summary>
		[DataMember(Name = "DisplayName", EmitDefaultValue = false)]
		public string DisplayName { get; set; }

		/// <summary>
		/// Gets or Sets InvoiceTemplateID
		/// </summary>
		[DataMember(Name = "InvoiceTemplateID", EmitDefaultValue = false)]
		public int? InvoiceTemplateID { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsDefaultCountry
		/// </summary>
		[DataMember(Name = "IsDefaultCountry", EmitDefaultValue = false)]
		public bool? IsDefaultCountry { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets QuoteTemplateID
		/// </summary>
		[DataMember(Name = "QuoteTemplateID", EmitDefaultValue = false)]
		public int? QuoteTemplateID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
