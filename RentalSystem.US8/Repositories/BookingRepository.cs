using RentalSystem.US8.Models;

namespace RentalSystem.US8.Repositories;

public class BookingRepository(List<Booking> bookings) : IBookingRepository
{

    public Booking? Get(Guid id)
    {
        return bookings.FirstOrDefault(booking => booking.Id == id);
    }
}
