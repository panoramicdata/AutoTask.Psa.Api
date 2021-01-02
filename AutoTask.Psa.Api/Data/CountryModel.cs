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
		public string CountryCode { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DisplayName
		/// </summary>
		[DataMember(Name = "DisplayName", EmitDefaultValue = false)]
		public string DisplayName { get; set; } = string.Empty;

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
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets QuoteTemplateID
		/// </summary>
		[DataMember(Name = "QuoteTemplateID", EmitDefaultValue = false)]
		public int? QuoteTemplateID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
