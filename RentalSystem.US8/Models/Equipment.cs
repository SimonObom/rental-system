using RentalSystem.US8.Enums;

namespace RentalSystem.US8.Models;

public class Equipment
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public Category Category { get; init; }
    public decimal Price { get; init; }
    public bool UnderMaintenance { get; set; }
}
