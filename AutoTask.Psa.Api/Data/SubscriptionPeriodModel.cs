using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// SubscriptionPeriodModel
	/// </summary>
	[DataContract]
	public partial class SubscriptionPeriodModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets PeriodCost
		/// </summary>
		[DataMember(Name = "PeriodCost", EmitDefaultValue = false)]
		public double? PeriodCost { get; set; }

		/// <summary>
		/// Gets or Sets PeriodDate
		/// </summary>
		[DataMember(Name = "PeriodDate", EmitDefaultValue = false)]
		public DateTime? PeriodDate { get; set; }

		/// <summary>
		/// Gets or Sets PeriodPrice
		/// </summary>
		[DataMember(Name = "PeriodPrice", EmitDefaultValue = false)]
		public double? PeriodPrice { get; set; }

		/// <summary>
		/// Gets or Sets PostedDate
		/// </summary>
		[DataMember(Name = "PostedDate", EmitDefaultValue = false)]
		public DateTime? PostedDate { get; set; }

		/// <summary>
		/// Gets or Sets PurchaseOrderNumber
		/// </summary>
		[DataMember(Name = "PurchaseOrderNumber", EmitDefaultValue = false)]
		public string PurchaseOrderNumber { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets SubscriptionID
		/// </summary>
		[DataMember(Name = "SubscriptionID", EmitDefaultValue = false)]
		public int? SubscriptionID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public long? SoapParentPropertyId { get; private set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; } = new();
	}
}
