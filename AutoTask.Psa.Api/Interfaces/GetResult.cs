namespace AutoTask.Psa.Api.Interfaces;

/// <summary>
/// Wraps a single item returned by a GET endpoint.
/// </summary>
/// <typeparam name="T">The type of the returned item.</typeparam>
[DataContract]
public class GetResult<T>
{
	/// <summary>Gets or sets the returned item.</summary>
	[DataMember(Name = "item")]
	public T Item { get; set; } = default!;
}