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
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyNegativeFormat
		/// </summary>
		[DataMember(Name = "CurrencyNegativeFormat", EmitDefaultValue = false)]
		public string CurrencyNegativeFormat { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets CurrencyPositiveFormat
		/// </summary>
		[DataMember(Name = "CurrencyPositiveFormat", EmitDefaultValue = false)]
		public string CurrencyPositiveFormat { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets DisplaySymbol
		/// </summary>
		[DataMember(Name = "DisplaySymbol", EmitDefaultValue = false)]
		public int? DisplaySymbol { get; set; }

		/// <summary>
		/// Gets or Sets ExchangeRate
		/// </summary>
		[DataMember(Name = "ExchangeRate", EmitDefaultValue = false)]
		public double? ExchangeRate { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsInternalCurrency
		/// </summary>
		[DataMember(Name = "IsInternalCurrency", EmitDefaultValue = false)]
		public bool? IsInternalCurrency { get; set; }

		/// <summary>
		/// Gets or Sets LastModifiedDateTime
		/// </summary>
		[DataMember(Name = "LastModifiedDateTime", EmitDefaultValue = false)]
		public DateTime? LastModifiedDateTime { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets UpdateResourceId
		/// </summary>
		[DataMember(Name = "UpdateResourceId", EmitDefaultValue = false)]
		public int? UpdateResourceId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
