using RentalSystem.US8.Models;
using RentalSystem.US8.Repositories;

namespace RentalSystem.US8.Services;

public class BookingService(IBookingRepository bookingRepository) : IBookingService
{
    public Booking? GetBooking(Guid id)
    {
        return bookingRepository.Get(id);
    }
}
