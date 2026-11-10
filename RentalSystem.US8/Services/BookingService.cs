using RentalSystem.US8.Models;
using RentalSystem.US8.Repositories;

namespace RentalSystem.US8.Services;

public class BookingService(IBookingRepository bookingRepository, IEquipmentRepository equipmentRepository) : IBookingService
{
    public Booking? GetBooking(Guid id)
    {
        var booking = bookingRepository.Get(id);

        if (booking is null)
        {
            return null;
        }

        booking.Equipment = equipmentRepository.Get(booking.EquipmentId);

        return booking;
    }

    public bool IsOngoing(Booking booking)
    {
        return booking.Status == RentalSystem.US8.Enums.Status.CheckedOut;
    }
}
