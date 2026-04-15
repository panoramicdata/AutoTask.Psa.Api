namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Pagination metadata returned by the AutoTask API.
/// </summary>
public class PageDetails
{
	/// <summary>Gets or sets the total number of items matching the query.</summary>
	[DataMember(Name = "count")]
	public int Count { get; set; }

	/// <summary>Gets or sets the number of items returned in this page.</summary>
	[DataMember(Name = "requestCount")]
	public int RequestCount { get; set; }

	/// <summary>Gets or sets the URL for the previous page of results, or <see langword="null"/> if this is the first page.</summary>
	[DataMember(Name = "prevPageUrl")]
	public string? PreviousPageUrl { get; set; }

	/// <summary>Gets or sets the URL for the next page of results, or <see langword="null"/> if this is the last page.</summary>
	[DataMember(Name = "nextPageUrl")]
	public string? NextPageUrl { get; set; }
}
