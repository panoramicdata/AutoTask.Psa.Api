﻿namespace AutoTask.Psa.Api.Data;

/// <summary>
/// Response
/// </summary>
[DataContract]
public class QueryActionResult<T>
{
	/// <summary>
	/// The items
	/// </summary>
	[DataMember(Name = "items")]
	public List<T> Items { get; set; } = null!;

	/// <summary>
	/// The page details
	/// </summary>
	[DataMember(Name = "pageDetails")]
	public PageDetails PageDetails { get; set; } = null!;
}
