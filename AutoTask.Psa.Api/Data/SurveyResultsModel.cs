using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// SurveyResultsModel
	/// </summary>
	[DataContract]
	public partial class SurveyResultsModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SurveyResultsModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CompanyID">CompanyID.</param>
		/// <param name="CompanyRating">CompanyRating.</param>
		/// <param name="CompleteDate">CompleteDate.</param>
		/// <param name="ContactID">ContactID.</param>
		/// <param name="ContactRating">ContactRating.</param>
		/// <param name="ResourceRating">ResourceRating.</param>
		/// <param name="SendDate">SendDate.</param>
		/// <param name="SurveyID">SurveyID.</param>
		/// <param name="SurveyRating">SurveyRating.</param>
		/// <param name="TicketID">TicketID.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public SurveyResultsModel(long? Id = default, int? CompanyID = default, double? CompanyRating = default, DateTime? CompleteDate = default, int? ContactID = default, double? ContactRating = default, double? ResourceRating = default, DateTime? SendDate = default, int? SurveyID = default, double? SurveyRating = default, int? TicketID = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CompanyID = CompanyID;
			this.CompanyRating = CompanyRating;
			this.CompleteDate = CompleteDate;
			this.ContactID = ContactID;
			this.ContactRating = ContactRating;
			this.ResourceRating = ResourceRating;
			this.SendDate = SendDate;
			this.SurveyID = SurveyID;
			this.SurveyRating = SurveyRating;
			this.TicketID = TicketID;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CompanyID
		/// </summary>
		[DataMember(Name = "CompanyID", EmitDefaultValue = false)]
		public int? CompanyID { get; set; }

		/// <summary>
		/// Gets or Sets CompanyRating
		/// </summary>
		[DataMember(Name = "CompanyRating", EmitDefaultValue = false)]
		public double? CompanyRating { get; set; }

		/// <summary>
		/// Gets or Sets CompleteDate
		/// </summary>
		[DataMember(Name = "CompleteDate", EmitDefaultValue = false)]
		public DateTime? CompleteDate { get; set; }

		/// <summary>
		/// Gets or Sets ContactID
		/// </summary>
		[DataMember(Name = "ContactID", EmitDefaultValue = false)]
		public int? ContactID { get; set; }

		/// <summary>
		/// Gets or Sets ContactRating
		/// </summary>
		[DataMember(Name = "ContactRating", EmitDefaultValue = false)]
		public double? ContactRating { get; set; }

		/// <summary>
		/// Gets or Sets ResourceRating
		/// </summary>
		[DataMember(Name = "ResourceRating", EmitDefaultValue = false)]
		public double? ResourceRating { get; set; }

		/// <summary>
		/// Gets or Sets SendDate
		/// </summary>
		[DataMember(Name = "SendDate", EmitDefaultValue = false)]
		public DateTime? SendDate { get; set; }

		/// <summary>
		/// Gets or Sets SurveyID
		/// </summary>
		[DataMember(Name = "SurveyID", EmitDefaultValue = false)]
		public int? SurveyID { get; set; }

		/// <summary>
		/// Gets or Sets SurveyRating
		/// </summary>
		[DataMember(Name = "SurveyRating", EmitDefaultValue = false)]
		public double? SurveyRating { get; set; }

		/// <summary>
		/// Gets or Sets TicketID
		/// </summary>
		[DataMember(Name = "TicketID", EmitDefaultValue = false)]
		public int? TicketID { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
