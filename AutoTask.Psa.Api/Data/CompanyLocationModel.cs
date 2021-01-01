using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CompanyLocationModel
	/// </summary>
	[DataContract]
	public partial class CompanyLocationModel
	{
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
		/// Gets or Sets AlternatePhone1
		/// </summary>
		[DataMember(Name = "AlternatePhone1", EmitDefaultValue = false)]
		public string AlternatePhone1 { get; set; }

		/// <summary>
		/// Gets or Sets AlternatePhone2
		/// </summary>
		[DataMember(Name = "AlternatePhone2", EmitDefaultValue = false)]
		public string AlternatePhone2 { get; set; }

		/// <summary>
		/// Gets or Sets City
		/// </summary>
		[DataMember(Name = "City", EmitDefaultValue = false)]
		public string City { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets CountryID
		/// </summary>
		[DataMember(Name = "CountryID", EmitDefaultValue = false)]
		public int? CountryID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets Fax
		/// </summary>
		[DataMember(Name = "Fax", EmitDefaultValue = false)]
		public string Fax { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsPrimary
		/// </summary>
		[DataMember(Name = "IsPrimary", EmitDefaultValue = false)]
		public bool? IsPrimary { get; set; }

		/// <summary>
		/// Gets or Sets IsTaxExempt
		/// </summary>
		[DataMember(Name = "IsTaxExempt", EmitDefaultValue = false)]
		public bool? IsTaxExempt { get; set; }

		/// <summary>
		/// Gets or Sets OverrideAccountTaxSettings
		/// </summary>
		[DataMember(Name = "OverrideAccountTaxSettings", EmitDefaultValue = false)]
		public bool? OverrideAccountTaxSettings { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets Phone
		/// </summary>
		[DataMember(Name = "Phone", EmitDefaultValue = false)]
		public string Phone { get; set; }

		/// <summary>
		/// Gets or Sets PostalCode
		/// </summary>
		[DataMember(Name = "PostalCode", EmitDefaultValue = false)]
		public string PostalCode { get; set; }

		/// <summary>
		/// Gets or Sets RoundtripDistance
		/// </summary>
		[DataMember(Name = "RoundtripDistance", EmitDefaultValue = false)]
		public double? RoundtripDistance { get; set; }

		/// <summary>
		/// Gets or Sets State
		/// </summary>
		[DataMember(Name = "State", EmitDefaultValue = false)]
		public string State { get; set; }

		/// <summary>
		/// Gets or Sets TaxRegionID
		/// </summary>
		[DataMember(Name = "TaxRegionID", EmitDefaultValue = false)]
		public int? TaxRegionID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncAccountPhysicalLocationInt64 SoapParentPropertyId { get; private set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
