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
