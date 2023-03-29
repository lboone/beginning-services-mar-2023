using System.ComponentModel.DataAnnotations;

namespace LocationsApi.Models;


public record LocationsResponse
{
    public IReadOnlyList<LocationItemResponse>? _embedded { get; set; }
}
public record LocationItemResponse
{
    public string Id { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public string AddedBy { get; init; } = string.Empty;
    public DateTime AddedOn { get; init; }
}

public record LocationCreate
{
    [Required, MaxLength(75)]
    public string Name { get; set; } = string.Empty;
    [Required, MaxLength(1000)]
    public string Description { get; set; } = string.Empty;
}
/*  {
    id: '1',
    name: "Aladdin's Eatery",
    description:
      'On Mayfield, good lunch time - lots of options for vegetarians',
    addedBy: 'Bob',
    addedOn: '2023-01-01',
  } */