using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// QuoteTemplateModel
	/// </summary>
	[DataContract]
	public partial class QuoteTemplateModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CalculateTaxSeparately
		/// </summary>
		[DataMember(Name = "CalculateTaxSeparately", EmitDefaultValue = false)]
		public bool? CalculateTaxSeparately { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate", EmitDefaultValue = false)]
		public DateTime? CreateDate { get; set; }

		/// <summary>
		/// Gets or Sets CreatedBy
		/// </summary>
		[DataMember(Name = "CreatedBy", EmitDefaultValue = false)]
		public int? CreatedBy { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyNegativeFormat
		/// </summary>
		[DataMember(Name = "CurrencyNegativeFormat", EmitDefaultValue = false)]
		public string CurrencyNegativeFormat { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyPositiveFormat
		/// </summary>
		[DataMember(Name = "CurrencyPositiveFormat", EmitDefaultValue = false)]
		public string CurrencyPositiveFormat { get; set; }

		/// <summary>
		/// Gets or Sets DateFormat
		/// </summary>
		[DataMember(Name = "DateFormat", EmitDefaultValue = false)]
		public int? DateFormat { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets DisplayTaxCategorySuperscripts
		/// </summary>
		[DataMember(Name = "DisplayTaxCategorySuperscripts", EmitDefaultValue = false)]
		public bool? DisplayTaxCategorySuperscripts { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityBy
		/// </summary>
		[DataMember(Name = "LastActivityBy", EmitDefaultValue = false)]
		public int? LastActivityBy { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityDate
		/// </summary>
		[DataMember(Name = "LastActivityDate", EmitDefaultValue = false)]
		public DateTime? LastActivityDate { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets NumberFormat
		/// </summary>
		[DataMember(Name = "NumberFormat", EmitDefaultValue = false)]
		public int? NumberFormat { get; set; }

		/// <summary>
		/// Gets or Sets PageLayout
		/// </summary>
		[DataMember(Name = "PageLayout", EmitDefaultValue = false)]
		public int? PageLayout { get; set; }

		/// <summary>
		/// Gets or Sets PageNumberFormat
		/// </summary>
		[DataMember(Name = "PageNumberFormat", EmitDefaultValue = false)]
		public int? PageNumberFormat { get; set; }

		/// <summary>
		/// Gets or Sets ShowEachTaxInGroup
		/// </summary>
		[DataMember(Name = "ShowEachTaxInGroup", EmitDefaultValue = false)]
		public bool? ShowEachTaxInGroup { get; set; }

		/// <summary>
		/// Gets or Sets ShowGridHeader
		/// </summary>
		[DataMember(Name = "ShowGridHeader", EmitDefaultValue = false)]
		public bool? ShowGridHeader { get; set; }

		/// <summary>
		/// Gets or Sets ShowTaxCategory
		/// </summary>
		[DataMember(Name = "ShowTaxCategory", EmitDefaultValue = false)]
		public bool? ShowTaxCategory { get; set; }

		/// <summary>
		/// Gets or Sets ShowVerticalGridLines
		/// </summary>
		[DataMember(Name = "ShowVerticalGridLines", EmitDefaultValue = false)]
		public bool? ShowVerticalGridLines { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
