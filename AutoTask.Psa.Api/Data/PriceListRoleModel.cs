using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// PriceListRoleModel
	/// </summary>
	[DataContract]
	public partial class PriceListRoleModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PriceListRoleModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CurrencyID">CurrencyID.</param>
		/// <param name="HourlyRate">HourlyRate.</param>
		/// <param name="RoleID">RoleID.</param>
		/// <param name="UsesInternalCurrencyPrice">UsesInternalCurrencyPrice.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public PriceListRoleModel(long? Id = default, int? CurrencyID = default, double? HourlyRate = default, int? RoleID = default, bool? UsesInternalCurrencyPrice = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CurrencyID = CurrencyID;
			this.HourlyRate = HourlyRate;
			this.RoleID = RoleID;
			this.UsesInternalCurrencyPrice = UsesInternalCurrencyPrice;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CurrencyID
		/// </summary>
		[DataMember(Name = "CurrencyID", EmitDefaultValue = false)]
		public int? CurrencyID { get; set; }

		/// <summary>
		/// Gets or Sets HourlyRate
		/// </summary>
		[DataMember(Name = "HourlyRate", EmitDefaultValue = false)]
		public double? HourlyRate { get; set; }

		/// <summary>
		/// Gets or Sets RoleID
		/// </summary>
		[DataMember(Name = "RoleID", EmitDefaultValue = false)]
		public int? RoleID { get; set; }

		/// <summary>
		/// Gets or Sets UsesInternalCurrencyPrice
		/// </summary>
		[DataMember(Name = "UsesInternalCurrencyPrice", EmitDefaultValue = false)]
		public bool? UsesInternalCurrencyPrice { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
