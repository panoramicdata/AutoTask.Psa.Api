using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ContractServiceUnitModel
	/// </summary>
	[DataContract]
	public partial class ContractServiceUnitModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ContractServiceUnitModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="ApproveAndPostDate">ApproveAndPostDate.</param>
		/// <param name="ContractID">ContractID.</param>
		/// <param name="ContractServiceID">ContractServiceID.</param>
		/// <param name="Cost">Cost.</param>
		/// <param name="EndDate">EndDate.</param>
		/// <param name="InternalCurrencyPrice">InternalCurrencyPrice.</param>
		/// <param name="OrganizationalLevelAssociationID">OrganizationalLevelAssociationID.</param>
		/// <param name="Price">Price.</param>
		/// <param name="ServiceID">ServiceID.</param>
		/// <param name="StartDate">StartDate.</param>
		/// <param name="Units">Units.</param>
		/// <param name="VendorCompanyID">VendorCompanyID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ContractServiceUnitModel(long? Id = default, DateTime? ApproveAndPostDate = default, int? ContractID = default, int? ContractServiceID = default, double? Cost = default, DateTime? EndDate = default, double? InternalCurrencyPrice = default, int? OrganizationalLevelAssociationID = default, double? Price = default, int? ServiceID = default, DateTime? StartDate = default, int? Units = default, int? VendorCompanyID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.ApproveAndPostDate = ApproveAndPostDate;
			this.ContractID = ContractID;
			this.ContractServiceID = ContractServiceID;
			this.Cost = Cost;
			this.EndDate = EndDate;
			this.InternalCurrencyPrice = InternalCurrencyPrice;
			this.OrganizationalLevelAssociationID = OrganizationalLevelAssociationID;
			this.Price = Price;
			this.ServiceID = ServiceID;
			this.StartDate = StartDate;
			this.Units = Units;
			this.VendorCompanyID = VendorCompanyID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets ApproveAndPostDate
		/// </summary>
		[DataMember(Name = "ApproveAndPostDate", EmitDefaultValue = false)]
		public DateTime? ApproveAndPostDate { get; set; }

		/// <summary>
		/// Gets or Sets ContractID
		/// </summary>
		[DataMember(Name = "ContractID", EmitDefaultValue = false)]
		public int? ContractID { get; set; }

		/// <summary>
		/// Gets or Sets ContractServiceID
		/// </summary>
		[DataMember(Name = "ContractServiceID", EmitDefaultValue = false)]
		public int? ContractServiceID { get; set; }

		/// <summary>
		/// Gets or Sets Cost
		/// </summary>
		[DataMember(Name = "Cost", EmitDefaultValue = false)]
		public double? Cost { get; set; }

		/// <summary>
		/// Gets or Sets EndDate
		/// </summary>
		[DataMember(Name = "EndDate", EmitDefaultValue = false)]
		public DateTime? EndDate { get; set; }

		/// <summary>
		/// Gets or Sets InternalCurrencyPrice
		/// </summary>
		[DataMember(Name = "InternalCurrencyPrice", EmitDefaultValue = false)]
		public double? InternalCurrencyPrice { get; set; }

		/// <summary>
		/// Gets or Sets OrganizationalLevelAssociationID
		/// </summary>
		[DataMember(Name = "OrganizationalLevelAssociationID", EmitDefaultValue = false)]
		public int? OrganizationalLevelAssociationID { get; set; }

		/// <summary>
		/// Gets or Sets Price
		/// </summary>
		[DataMember(Name = "Price", EmitDefaultValue = false)]
		public double? Price { get; set; }

		/// <summary>
		/// Gets or Sets ServiceID
		/// </summary>
		[DataMember(Name = "ServiceID", EmitDefaultValue = false)]
		public int? ServiceID { get; set; }

		/// <summary>
		/// Gets or Sets StartDate
		/// </summary>
		[DataMember(Name = "StartDate", EmitDefaultValue = false)]
		public DateTime? StartDate { get; set; }

		/// <summary>
		/// Gets or Sets Units
		/// </summary>
		[DataMember(Name = "Units", EmitDefaultValue = false)]
		public int? Units { get; set; }

		/// <summary>
		/// Gets or Sets VendorCompanyID
		/// </summary>
		[DataMember(Name = "VendorCompanyID", EmitDefaultValue = false)]
		public int? VendorCompanyID { get; set; }

		/// <summary>
		/// Gets or Sets SoapParentPropertyId
		/// </summary>
		[DataMember(Name = "SoapParentPropertyId", EmitDefaultValue = false)]
		public long? SoapParentPropertyId { get; private set; }
		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
