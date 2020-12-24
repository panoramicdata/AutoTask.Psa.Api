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
	public partial class ActionTypeModel : IEquatable<ActionTypeModel>, IValidatableObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ActionTypeModel" /> class.
		/// </summary>
		/// <param name="Id">Id.</param>
		/// <param name="Name">Name.</param>
		/// <param name="IsActive">IsActive.</param>
		/// <param name="IsSystemActionType">IsSystemActionType.</param>
		/// <param name="View">View.</param>
		/// <param name="UserDefinedFields">UserDefinedFields.</param>
		public ActionTypeModel(
			 long? Id = default,
			 string Name = default,
			 bool? IsActive = default,
			 bool? IsSystemActionType = default,
			 int? View = default,
			 List<UserDefinedField> UserDefinedFields = default)
		{
			this.Id = Id;
			this.Name = Name;
			this.IsActive = IsActive;
			this.IsSystemActionType = IsSystemActionType;
			this.View = View;
			this.UserDefinedFields = UserDefinedFields;
		}

		/// <summary>
		/// Gets or Sets Id
		/// </summary>
		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public long? Id { get; set; }
		/// <summary>
		/// Gets or Sets Name
		/// </summary>
		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }
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
		public List<UserDefinedField> UserDefinedFields { get; set; }
		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ActionTypeModel {\n");
			sb.Append("  Id: ").Append(Id).Append("\n");
			sb.Append("  Name: ").Append(Name).Append("\n");
			sb.Append("  IsActive: ").Append(IsActive).Append("\n");
			sb.Append("  IsSystemActionType: ").Append(IsSystemActionType).Append("\n");
			sb.Append("  View: ").Append(View).Append("\n");
			sb.Append("  UserDefinedFields: ").Append(UserDefinedFields).Append("\n");
			sb.Append("}\n");
			return sb.ToString();
		}

		/// <summary>
		/// Returns the JSON string presentation of the object
		/// </summary>
		/// <returns>JSON string presentation of the object</returns>
		public string ToJson()
		{
			return JsonConvert.SerializeObject(this, Formatting.Indented);
		}

		/// <summary>
		/// Returns true if objects are equal
		/// </summary>
		/// <param name="obj">Object to be compared</param>
		/// <returns>Boolean</returns>
		public override bool Equals(object obj)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			return Equals(obj as ActionTypeModel);
		}

		/// <summary>
		/// Returns true if ActionTypeModel instances are equal
		/// </summary>
		/// <param name="other">Instance of ActionTypeModel to be compared</param>
		/// <returns>Boolean</returns>
		public bool Equals(ActionTypeModel other)
		{
			// credit: http://stackoverflow.com/a/10454552/677735
			if (other == null)
				return false;

			return
				 (
					  Id == other.Id ||
					  (Id != null &&
					  Id.Equals(other.Id))
				 ) &&
				 (
					  Name == other.Name ||
					  Name?.Equals(other.Name) == true
				 ) &&
				 (
					  IsActive == other.IsActive ||
					  (IsActive != null &&
					  IsActive.Equals(other.IsActive))
				 ) &&
				 (
					  IsSystemActionType == other.IsSystemActionType ||
					  (IsSystemActionType != null &&
					  IsSystemActionType.Equals(other.IsSystemActionType))
				 ) &&
				 (
					  View == other.View ||
					  (View != null &&
					  View.Equals(other.View))
				 ) &&
				 (
					  UserDefinedFields == other.UserDefinedFields ||
					  (UserDefinedFields?.SequenceEqual(other.UserDefinedFields) == true)
				 );
		}

		/// <summary>
		/// Gets the hash code
		/// </summary>
		/// <returns>Hash code</returns>
		public override int GetHashCode()
		{
			// credit: http://stackoverflow.com/a/263416/677735
			unchecked // Overflow is fine, just wrap
			{
				int hash = 41;
				// Suitable nullity checks etc, of course :)
				if (Id != null)
					hash = (hash * 59) + Id.GetHashCode();
				if (Name != null)
					hash = (hash * 59) + Name.GetHashCode();
				if (IsActive != null)
					hash = (hash * 59) + IsActive.GetHashCode();
				if (IsSystemActionType != null)
					hash = (hash * 59) + IsSystemActionType.GetHashCode();
				if (View != null)
					hash = (hash * 59) + View.GetHashCode();
				if (UserDefinedFields != null)
					hash = (hash * 59) + UserDefinedFields.GetHashCode();
				return hash;
			}
		}

		/// <summary>
		/// To validate all properties of the instance
		/// </summary>
		/// <param name="validationContext">Validation context</param>
		/// <returns>Validation Result</returns>
		IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
		{
			yield break;
		}
	}
}
