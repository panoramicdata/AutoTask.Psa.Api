using System.Globalization;

namespace AutoTask.Psa.Api.Test;

public class DuplicateDeletionTests(
	ITestOutputHelper testOutputHelper,
	Fixture fixture) : TestBase(testOutputHelper, fixture)
{
	private const string TicketId = "935869";
	private const string DescriptionPrefix = "Certify:";

	[Fact]
	public async Task QueryAsync_WithString_Succeeds()
	{
		var duplicates = await FindDuplicateTicketChargesAsync();

		await DeleteTicketChargesAsync(duplicates);
	}

	/// <summary>
	/// Walks the last six months a day at a time, collecting ticket charges whose description has
	/// already been seen. The window is per-day because a single query is capped at 500 records.
	/// </summary>
	private async Task<List<TicketChargeModel>> FindDuplicateTicketChargesAsync()
	{
		var utcNow = DateTimeOffset.UtcNow;
		var timeCursor = utcNow.AddMonths(-6);
		var observedDescriptions = new HashSet<string>();
		var duplicateTicketCharges = new List<TicketChargeModel>();

		while (timeCursor < utcNow)
		{
			var response = await AutoTaskClient
				.TicketCharges
				.QueryAsync(CreateDayQuery(timeCursor));

			response.Should().NotBeNull(because: "a valid request should return a response object");

			foreach (var ticketCharge in response.Items)
			{
				if (!observedDescriptions.Add(ticketCharge.Description))
				{
					duplicateTicketCharges.Add(ticketCharge);
				}
			}

			timeCursor = timeCursor.AddDays(1);
		}

		return duplicateTicketCharges;
	}

	/// <summary>
	/// Builds a query for the ticket charges created on the single day starting at <paramref name="dayStart"/>.
	/// </summary>
	private static QueryModel CreateDayQuery(DateTimeOffset dayStart)
		=> new()
		{
			Filter = [
				new Filter { Field = "TicketID", Op = "eq", Value = TicketId },
				new Filter { Field = "Description", Op = "BeginsWith", Value = DescriptionPrefix },
				new Filter { Field = "CreateDate", Op = "gte", Value = FormatDate(dayStart) },
				new Filter { Field = "CreateDate", Op = "lt", Value = FormatDate(dayStart.AddDays(1)) },
			],
			MaxRecords = 500
		};

	private static string FormatDate(DateTimeOffset value)
		=> value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

	/// <summary>
	/// Deletes each of <paramref name="ticketCharges"/>, logging rather than throwing when one delete fails.
	/// </summary>
	private async Task DeleteTicketChargesAsync(List<TicketChargeModel> ticketCharges)
	{
		var count = ticketCharges.Count;
		var index = 0;
		foreach (var ticketCharge in ticketCharges)
		{
			index++;
			if (Log.IsEnabled(LogLevel.Debug))
			{
				Log.LogDebug(
					"Deleting duplicate ticket charge {Index} of {Count}",
					index,
					count);
			}

			await DeleteTicketChargeAsync(ticketCharge);
		}
	}

	/// <summary>
	/// Deletes a single ticket charge, after re-checking it is one this test is allowed to delete.
	/// </summary>
	private async Task DeleteTicketChargeAsync(TicketChargeModel ticketCharge)
	{
		if (!ticketCharge.TicketID.HasValue)
		{
			throw new FormatException("Missing Ticket Id");
		}

		if (!ticketCharge.Id.HasValue)
		{
			throw new FormatException("Missing Ticket Charge Id");
		}

		if (!ticketCharge.Description.StartsWith(DescriptionPrefix, StringComparison.Ordinal))
		{
			throw new FormatException("Unexpected description.");
		}

		try
		{
			await AutoTaskClient
				.TicketCharges
				.DeleteAsync(ticketCharge.TicketID.Value, ticketCharge.Id.Value);
		}
		catch (Exception e)
		{
			Log.LogError(e, "Failed to delete ticket charge {TicketChargeId}", ticketCharge.Id.Value);
		}
	}
}
