using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ConfigurationItemBillingProductAssociationModel
	/// </summary>
	[DataContract]
	public partial class ConfigurationItemBillingProductAssociationModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConfigurationItemBillingProductAssociationModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BillingProductID">BillingProductID.</param>
		/// <param name="ConfigurationItemID">ConfigurationItemID.</param>
		/// <param name="EffectiveDate">EffectiveDate.</param>
		/// <param name="ExpirationDate">ExpirationDate.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ConfigurationItemBillingProductAssociationModel(long? Id = default, int? BillingProductID = default, int? ConfigurationItemID = default, DateTime? EffectiveDate = default, DateTime? ExpirationDate = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BillingProductID = BillingProductID;
			this.ConfigurationItemID = ConfigurationItemID;
			this.EffectiveDate = EffectiveDate;
			this.ExpirationDate = ExpirationDate;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets BillingProductID
		/// </summary>
		[DataMember(Name = "BillingProductID", EmitDefaultValue = false)]
		public int? BillingProductID { get; set; }

		/// <summary>
		/// Gets or Sets ConfigurationItemID
		/// </summary>
		[DataMember(Name = "ConfigurationItemID", EmitDefaultValue = false)]
		public int? ConfigurationItemID { get; set; }

		/// <summary>
		/// Gets or Sets EffectiveDate
		/// </summary>
		[DataMember(Name = "EffectiveDate", EmitDefaultValue = false)]
		public DateTime? EffectiveDate { get; set; }

		/// <summary>
		/// Gets or Sets ExpirationDate
		/// </summary>
		[DataMember(Name = "ExpirationDate", EmitDefaultValue = false)]
		public DateTime? ExpirationDate { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public ExpressionFuncInstalledProductBillingProductAssociationInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
