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
		/// Initializes a new instance of the <see cref="ServiceLevelAgreementResultsModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="FirstResponseElapsedHours">FirstResponseElapsedHours.</param>
		/// <param name="FirstResponseInitiatingResourceID">FirstResponseInitiatingResourceID.</param>
		/// <param name="FirstResponseResourceID">FirstResponseResourceID.</param>
		/// <param name="IsFirstResponseMet">IsFirstResponseMet.</param>
		/// <param name="IsResolutionMet">IsResolutionMet.</param>
		/// <param name="IsResolutionPlanMet">IsResolutionPlanMet.</param>
		/// <param name="ResolutionElapsedHours">ResolutionElapsedHours.</param>
		/// <param name="ResolutionPlanElapsedHours">ResolutionPlanElapsedHours.</param>
		/// <param name="ResolutionPlanResourceID">ResolutionPlanResourceID.</param>
		/// <param name="ResolutionResourceID">ResolutionResourceID.</param>
		/// <param name="ServiceLevelAgreementName">ServiceLevelAgreementName.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ServiceLevelAgreementResultsModel(long? Id = default, double? FirstResponseElapsedHours = default, int? FirstResponseInitiatingResourceID = default, int? FirstResponseResourceID = default, bool? IsFirstResponseMet = default, bool? IsResolutionMet = default, bool? IsResolutionPlanMet = default, double? ResolutionElapsedHours = default, double? ResolutionPlanElapsedHours = default, int? ResolutionPlanResourceID = default, int? ResolutionResourceID = default, string ServiceLevelAgreementName = default, int? TicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.FirstResponseElapsedHours = FirstResponseElapsedHours;
			this.FirstResponseInitiatingResourceID = FirstResponseInitiatingResourceID;
			this.FirstResponseResourceID = FirstResponseResourceID;
			this.IsFirstResponseMet = IsFirstResponseMet;
			this.IsResolutionMet = IsResolutionMet;
			this.IsResolutionPlanMet = IsResolutionPlanMet;
			this.ResolutionElapsedHours = ResolutionElapsedHours;
			this.ResolutionPlanElapsedHours = ResolutionPlanElapsedHours;
			this.ResolutionPlanResourceID = ResolutionPlanResourceID;
			this.ResolutionResourceID = ResolutionResourceID;
			this.ServiceLevelAgreementName = ServiceLevelAgreementName;
			this.TicketID = TicketID;
			this.UserDefinedFields = UserDefinedFields;
		}

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
		public string ServiceLevelAgreementName { get; set; }

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
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
