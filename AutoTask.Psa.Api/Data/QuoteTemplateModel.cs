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
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CalculateTaxSeparately
		/// </summary>
		[DataMember(Name = "CalculateTaxSeparately")]
		public bool? CalculateTaxSeparately { get; set; }

		/// <summary>
		/// Gets or Sets CreateDate
		/// </summary>
		[DataMember(Name = "CreateDate")]
		public DateTime? CreateDate { get; set; }

		/// <summary>
		/// Gets or Sets CreatedBy
		/// </summary>
		[DataMember(Name = "CreatedBy")]
		public int? CreatedBy { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyNegativeFormat
		/// </summary>
		[DataMember(Name = "CurrencyNegativeFormat")]
		public string CurrencyNegativeFormat { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets CurrencyPositiveFormat
		/// </summary>
		[DataMember(Name = "CurrencyPositiveFormat")]
		public string CurrencyPositiveFormat { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DateFormat
		/// </summary>
		[DataMember(Name = "DateFormat")]
		public int? DateFormat { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DisplayTaxCategorySuperscripts
		/// </summary>
		[DataMember(Name = "DisplayTaxCategorySuperscripts")]
		public bool? DisplayTaxCategorySuperscripts { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive")]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityBy
		/// </summary>
		[DataMember(Name = "LastActivityBy")]
		public int? LastActivityBy { get; set; }

		/// <summary>
		/// Gets or Sets LastActivityDate
		/// </summary>
		[DataMember(Name = "LastActivityDate")]
		public DateTime? LastActivityDate { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets NumberFormat
		/// </summary>
		[DataMember(Name = "NumberFormat")]
		public int? NumberFormat { get; set; }

		/// <summary>
		/// Gets or Sets PageLayout
		/// </summary>
		[DataMember(Name = "PageLayout")]
		public int? PageLayout { get; set; }

		/// <summary>
		/// Gets or Sets PageNumberFormat
		/// </summary>
		[DataMember(Name = "PageNumberFormat")]
		public int? PageNumberFormat { get; set; }

		/// <summary>
		/// Gets or Sets ShowEachTaxInGroup
		/// </summary>
		[DataMember(Name = "ShowEachTaxInGroup")]
		public bool? ShowEachTaxInGroup { get; set; }

		/// <summary>
		/// Gets or Sets ShowGridHeader
		/// </summary>
		[DataMember(Name = "ShowGridHeader")]
		public bool? ShowGridHeader { get; set; }

		/// <summary>
		/// Gets or Sets ShowTaxCategory
		/// </summary>
		[DataMember(Name = "ShowTaxCategory")]
		public bool? ShowTaxCategory { get; set; }

		/// <summary>
		/// Gets or Sets ShowVerticalGridLines
		/// </summary>
		[DataMember(Name = "ShowVerticalGridLines")]
		public bool? ShowVerticalGridLines { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
