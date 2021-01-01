using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace AutoTask.Psa.Api.Data
{
	/// <summary>
	/// ActionTypeModel
	/// </summary>
	[DataContract]
	public partial class ActionTypeModel
	{
		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }

		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Gets or Sets IsActive
		/// </summary>
		[DataMember(Name = "IsActive", EmitDefaultValue = false)]
		public bool? IsActive { get; set; }

		/// <summary>
		/// Gets or Sets IsSystemActionType
		/// </summary>
		[DataMember(Name = "IsSystemActionType", EmitDefaultValue = false)]
		public bool? IsSystemActionType { get; set; }

		/// <summary>
		/// Gets or Sets View
		/// </summary>
		[DataMember(Name = "View", EmitDefaultValue = false)]
		public int? View { get; set; }

		/// <summary>
		/// Gets or Sets UserDefinedFields
		/// </summary>
		[DataMember(Name = "UserDefinedFields", EmitDefaultValue = false)]
		public List<UserDefinedField>? UserDefinedFields { get; set; }
	}
}
