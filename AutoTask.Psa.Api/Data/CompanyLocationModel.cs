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
		/// Initializes a new instance of the <see cref="CompanyLocationModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Address1">Address1.</param>
		/// <param name="Address2">Address2.</param>
		/// <param name="AlternatePhone1">AlternatePhone1.</param>
		/// <param name="AlternatePhone2">AlternatePhone2.</param>
		/// <param name="City">City.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="CountryID">CountryID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="Fax">Fax.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsPrimary">IsPrimary.</param>
		/// <param name="IsTaxExempt">IsTaxExempt.</param>
		/// <param name="OverrideAccountTaxSettings">OverrideAccountTaxSettings.</param>
		/// <param name="Name">Name.</param>
		/// <param name="Phone">Phone.</param>
		/// <param name="PostalCode">PostalCode.</param>
		/// <param name="RoundtripDistance">RoundtripDistance.</param>
		/// <param name="State">State.</param>
		/// <param name="TaxRegionID">TaxRegionID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public CompanyLocationModel(long? Id = default, string Address1 = default, string Address2 = default, string AlternatePhone1 = default, string AlternatePhone2 = default, string City = default, int? CompanyID = default, int? CountryID = default, string Description = default, string Fax = default, bool? IsActive = default, bool? IsPrimary = default, bool? IsTaxExempt = default, bool? OverrideAccountTaxSettings = default, string Name = default, string Phone = default, string PostalCode = default, double? RoundtripDistance = default, string State = default, int? TaxRegionID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.Address1 = Address1;
			this.Address2 = Address2;
			this.AlternatePhone1 = AlternatePhone1;
			this.AlternatePhone2 = AlternatePhone2;
			this.City = City;
			this.CompanyID = CompanyID;
			this.CountryID = CountryID;
			this.Description = Description;
			this.Fax = Fax;
			this.IsActive = IsActive;
			this.IsPrimary = IsPrimary;
			this.IsTaxExempt = IsTaxExempt;
			this.OverrideAccountTaxSettings = OverrideAccountTaxSettings;
			this.Name = Name;
			this.Phone = Phone;
			this.PostalCode = PostalCode;
			this.RoundtripDistance = RoundtripDistance;
			this.State = State;
			this.TaxRegionID = TaxRegionID;
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
