using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// AppointmentModel
	/// </summary>
	[DataContract]
	public partial class AppointmentModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="AppointmentModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="CreateDateTime">CreateDateTime.</param>
		/// <param name="CreatorResourceID">CreatorResourceID.</param>
		/// <param name="Description">Description.</param>
		/// <param name="EndDateTime">EndDateTime.</param>
		/// <param name="ResourceID">ResourceID.</param>
		/// <param name="StartDateTime">StartDateTime.</param>
		/// <param name="Title">Title.</param>
		/// <param name="UpdateDateTime">UpdateDateTime.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public AppointmentModel(long? Id = default, DateTime? CreateDateTime = default, int? CreatorResourceID = default, string Description = default, DateTime? EndDateTime = default, int? ResourceID = default, DateTime? StartDateTime = default, string Title = default, DateTime? UpdateDateTime = default, List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.CreateDateTime = CreateDateTime;
			this.CreatorResourceID = CreatorResourceID;
			this.Description = Description;
			this.EndDateTime = EndDateTime;
			this.ResourceID = ResourceID;
			this.StartDateTime = StartDateTime;
			this.Title = Title;
			this.UpdateDateTime = UpdateDateTime;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets CreateDateTime
		/// </summary>
		[DataMember(Name = "CreateDateTime", EmitDefaultValue = false)]
		public DateTime? CreateDateTime { get; set; }

		/// <summary>
		/// Gets or Sets CreatorResourceID
		/// </summary>
		[DataMember(Name = "CreatorResourceID", EmitDefaultValue = false)]
		public int? CreatorResourceID { get; set; }

		/// <summary>
		/// Gets or Sets Description
		/// </summary>
		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		/// <summary>
		/// Gets or Sets EndDateTime
		/// </summary>
		[DataMember(Name = "EndDateTime", EmitDefaultValue = false)]
		public DateTime? EndDateTime { get; set; }

		/// <summary>
		/// Gets or Sets ResourceID
		/// </summary>
		[DataMember(Name = "ResourceID", EmitDefaultValue = false)]
		public int? ResourceID { get; set; }

		/// <summary>
		/// Gets or Sets StartDateTime
		/// </summary>
		[DataMember(Name = "StartDateTime", EmitDefaultValue = false)]
		public DateTime? StartDateTime { get; set; }

		/// <summary>
		/// Gets or Sets Title
		/// </summary>
		[DataMember(Name = "Title", EmitDefaultValue = false)]
		public string Title { get; set; }

		/// <summary>
		/// Gets or Sets UpdateDateTime
		/// </summary>
		[DataMember(Name = "UpdateDateTime", EmitDefaultValue = false)]
		public DateTime? UpdateDateTime { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField> UserDefinedFields { get; set; }
	}
}
