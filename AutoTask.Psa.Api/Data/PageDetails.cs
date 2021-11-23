namespace AutoTask.Psa.Api.Data;

public class PageDetails
{
	[DataMember(Name = "count")]
	public int Count { get; set; }

	[DataMember(Name = "requestCount")]
	public int RequestCount { get; set; }

	[DataMember(Name = "prevPageUrl")]
	public string? PreviousPageUrl { get; set; }

	[DataMember(Name = "nextPageUrl")]
	public string? NextPageUrl { get; set; }
}
