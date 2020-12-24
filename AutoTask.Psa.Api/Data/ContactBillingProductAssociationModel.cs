using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContactBillingProductAssociationModel
	/// </summary>
	[DataContract]
	public partial class ContactBillingProductAssociationModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContactBillingProductAssociationModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="BillingProductID">BillingProductID.</param>
		/// <param name="ContactID">ContactID.</param>
		/// <param name="EffectiveDate">EffectiveDate.</param>
		/// <param name="ExpirationDate">ExpirationDate.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContactBillingProductAssociationModel(long? Id = default, int? BillingProductID = default, int? ContactID = default, DateTime? EffectiveDate = default, DateTime? ExpirationDate = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.BillingProductID = BillingProductID;
			this.ContactID = ContactID;
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
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public int? ContactID { get; set; }

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
		public ExpressionFuncContactBillingProductAssociationInt64 SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
