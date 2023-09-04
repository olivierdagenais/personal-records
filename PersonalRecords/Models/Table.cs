using System;

namespace PersonalRecords.Models;

public record Table
{
	public string Name { get; init; }

	public string Type { get; init; }

	public string DisplayName { get; init; }

	public string Description { get; init; }

	public DateTime LastEntryDate { get; init; }

	public string LastEntryDescription { get; init; }

	public string LastEntryValue { get; init; }
}
