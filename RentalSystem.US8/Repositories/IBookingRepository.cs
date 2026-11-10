using RentalSystem.US8.Models;

namespace RentalSystem.US8.Repositories;

public interface IBookingRepository
{
    Booking? Get(Guid id);
}
