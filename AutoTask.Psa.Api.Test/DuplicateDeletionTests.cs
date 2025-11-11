using System.Globalization;

namespace AutoTask.Psa.Api.Test;

public class DuplicateDeletionTests(
	ITestOutputHelper testOutputHelper,
	Fixture fixture) : TestBase(testOutputHelper, fixture)
{
	[Fact]
	public async Task QueryAsync_WithString_Succeeds()
	{
		var utcNow = DateTimeOffset.UtcNow;
		var timeCursor = utcNow.AddMonths(-6);
		var observedDescriptions = new HashSet<string>();
		var duplicateTicketCharges = new List<TicketChargeModel>();

		while (timeCursor < utcNow)
		{
			var startDateString = timeCursor.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
			var endDateString = timeCursor.AddDays(1).ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

			var response = await AutoTaskClient
				.TicketCharges
				.QueryAsync(new QueryModel
				{
					Filter = [
						new Filter
					{
						Field = "TicketID",
						Op = "eq",
						Value = "935869"
					},
						new Filter
					{
						Field = "Description",
						Op = "BeginsWith",
						Value = "Certify:"
					},
					new Filter
					{
						Field = "CreateDate",
						Op = "gte",
						Value = startDateString
					},
					new Filter
					{
						Field = "CreateDate",
						Op = "lt",
						Value = endDateString
					},
					],
					MaxRecords = 500
					//IncludeFields = ["id", "description"]
				}
			);

			response.Should().NotBeNull(because: "a valid request should return a response object");

			foreach (var ticketCharge in response.Items)
			{
				if (observedDescriptions.Contains(ticketCharge.Description))
				{
					duplicateTicketCharges.Add(ticketCharge);
				}
				else
				{
					observedDescriptions.Add(ticketCharge.Description);
				}
			}

			timeCursor = timeCursor.AddDays(1);
		}

		var count = duplicateTicketCharges.Count;
		var index = 0;
		foreach (var duplicateTicketCharge in duplicateTicketCharges)
		{
			index++;
			Log.LogDebug(
				"Deleting duplicate ticket charge {Index} of {Count}",
				index,
				count);

			if (!duplicateTicketCharge.TicketID.HasValue)
			{
				throw new FormatException("Missing Ticket Id");
			}

			if (!duplicateTicketCharge.Id.HasValue)
			{
				throw new FormatException("Missing Ticket Charge Id");
			}

			if (!duplicateTicketCharge.Description.StartsWith("Certify:", StringComparison.Ordinal))
			{
				throw new FormatException("Unexpected description.");
			}

			try
			{
				await AutoTaskClient
					.TicketCharges
					.DeleteAsync(duplicateTicketCharge.TicketID.Value, duplicateTicketCharge.Id.Value);
			}
			catch (Exception e)
			{
				testOutputHelper.WriteLine($"Failed to delete ticket charge {duplicateTicketCharge.Id.Value}: {e.Message}");
			}
		}
	}
}