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
		/// Initializes a new instance of the <see cref="CurrencyModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CurrencyNegativeFormat">CurrencyNegativeFormat.</param>
		/// <param name="CurrencyPositiveFormat">CurrencyPositiveFormat.</param>
		/// <param name="Description">Description.</param>
		/// <param name="DisplaySymbol">DisplaySymbol.</param>
		/// <param name="ExchangeRate">ExchangeRate.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsInternalCurrency">IsInternalCurrency.</param>
		/// <param name="LastModifiedDateTime">LastModifiedDateTime.</param>
		/// <param name="Name">Name.</param>
		/// <param name="UpdateResourceId">UpdateResourceId.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public CurrencyModel(long? Id = default, string CurrencyNegativeFormat = default, string CurrencyPositiveFormat = default, string Description = default, int? DisplaySymbol = default, double? ExchangeRate = default, bool? IsActive = default, bool? IsInternalCurrency = default, DateTime? LastModifiedDateTime = default, string Name = default, int? UpdateResourceId = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CurrencyNegativeFormat = CurrencyNegativeFormat;
			this.CurrencyPositiveFormat = CurrencyPositiveFormat;
			this.Description = Description;
			this.DisplaySymbol = DisplaySymbol;
			this.ExchangeRate = ExchangeRate;
			this.IsActive = IsActive;
			this.IsInternalCurrency = IsInternalCurrency;
			this.LastModifiedDateTime = LastModifiedDateTime;
			this.Name = Name;
			this.UpdateResourceId = UpdateResourceId;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

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
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

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
		public string Name { get; set; }

		/// <summary>
		/// Gets or Sets UpdateResourceId
		/// </summary>
		[DataMember(Name = "UpdateResourceId", EmitDefaultValue = false)]
		public int? UpdateResourceId { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
