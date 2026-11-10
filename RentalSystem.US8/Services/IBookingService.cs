using RentalSystem.US8.Models;

namespace RentalSystem.US8.Services;

public interface IBookingService
{
    Booking? GetBooking(Guid id);
}
