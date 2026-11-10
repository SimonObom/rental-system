using RentalSystem.US8.Enums;

namespace RentalSystem.US8.Models;

public class Booking
{
    public Guid Id { get; init; }
    public Guid EquipmentId { get; init; }
    public Guid CustomerId { get; init; }
    public DateOnly StartDate { get; init; }
    public DateOnly EndDate { get; init; }
    public Guid? CheckedOutByEmployeeId { get; set; }
    public Guid? ReturnedByEmployeeId { get; set; }
    public Status Status { get; set; }
    public decimal TotalPrice { get; init; }
}
