using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ServiceLevelAgreementResultsModel
	/// </summary>
	[DataContract]
	public partial class ServiceLevelAgreementResultsModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets FirstResponseElapsedHours
		/// </summary>
		[DataMember(Name = "FirstResponseElapsedHours", EmitDefaultValue = false)]
		public double? FirstResponseElapsedHours { get; set; }

		/// <summary>
		/// Gets or Sets FirstResponseInitiatingResourceID
		/// </summary>
		[DataMember(Name = "FirstResponseInitiatingResourceID", EmitDefaultValue = false)]
		public int? FirstResponseInitiatingResourceID { get; set; }

		/// <summary>
		/// Gets or Sets FirstResponseResourceID
		/// </summary>
		[DataMember(Name = "FirstResponseResourceID", EmitDefaultValue = false)]
		public int? FirstResponseResourceID { get; set; }

		/// <summary>
		/// Gets or Sets IsFirstResponseMet
		/// </summary>
		[DataMember(Name = "IsFirstResponseMet", EmitDefaultValue = false)]
		public bool? IsFirstResponseMet { get; set; }

		/// <summary>
		/// Gets or Sets IsResolutionMet
		/// </summary>
		[DataMember(Name = "IsResolutionMet", EmitDefaultValue = false)]
		public bool? IsResolutionMet { get; set; }

		/// <summary>
		/// Gets or Sets IsResolutionPlanMet
		/// </summary>
		[DataMember(Name = "IsResolutionPlanMet", EmitDefaultValue = false)]
		public bool? IsResolutionPlanMet { get; set; }

		/// <summary>
		/// Gets or Sets ResolutionElapsedHours
		/// </summary>
		[DataMember(Name = "ResolutionElapsedHours", EmitDefaultValue = false)]
		public double? ResolutionElapsedHours { get; set; }

		/// <summary>
		/// Gets or Sets ResolutionPlanElapsedHours
		/// </summary>
		[DataMember(Name = "ResolutionPlanElapsedHours", EmitDefaultValue = false)]
		public double? ResolutionPlanElapsedHours { get; set; }

		/// <summary>
		/// Gets or Sets ResolutionPlanResourceID
		/// </summary>
		[DataMember(Name = "ResolutionPlanResourceID", EmitDefaultValue = false)]
		public int? ResolutionPlanResourceID { get; set; }

		/// <summary>
		/// Gets or Sets ResolutionResourceID
		/// </summary>
		[DataMember(Name = "ResolutionResourceID", EmitDefaultValue = false)]
		public int? ResolutionResourceID { get; set; }

		/// <summary>
		/// Gets or Sets ServiceLevelAgreementName
		/// </summary>
		[DataMember(Name = "ServiceLevelAgreementName", EmitDefaultValue = false)]
		public string ServiceLevelAgreementName { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

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
