using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// CurrencyModel
	/// </summary>
	[DataContract]
	public partial class CurrencyModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id")]
		public long? Id { get; set; }

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
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DisplaySymbol
		/// </summary>
		[DataMember(Name = "DisplaySymbol")]
		public int? DisplaySymbol { get; set; }

		/// <summary>
		/// Gets or Sets ExchangeRate
		/// </summary>
		[DataMember(Name = "ExchangeRate")]
		public double? ExchangeRate { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive")]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsInternalCurrency
		/// </summary>
		[DataMember(Name = "IsInternalCurrency")]
		public bool? IsInternalCurrency { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedDateTime
		/// </summary>
		[DataMember(Name = "LastModifiedDateTime")]
		public DateTime? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets UpdateResourceId
		/// </summary>
		[DataMember(Name = "UpdateResourceId")]
		public int? UpdateResourceId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields")]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
