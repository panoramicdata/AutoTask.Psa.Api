namespace AutoTask.Psa.Api.Interfaces;

[DataContract]
public class GetResult<T>
{
	[DataMember(Name = "item")]
	public T Item { get; set; } = default!;
}