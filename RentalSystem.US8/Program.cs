
using RentalSystem.US8.Enums;
using RentalSystem.US8.Models;
using RentalSystem.US8.Repositories;
using RentalSystem.US8.Services;
using RentalSystem.US8.Views;

var bookings = new List<Booking>
{
    new Booking
    {
        Id = Guid.Parse("6e4af0f5-172a-4509-adfb-819f0e3b2dc0"),
        EquipmentId = Guid.NewGuid(),
        CustomerId = Guid.NewGuid(),
        StartDate = DateOnly.FromDateTime(DateTime.Today),
        EndDate = DateOnly.FromDateTime(DateTime.Today.AddDays(3)),
        Status = Status.CheckedOut,
        TotalPrice = 500m
    }
};

IBookingRepository bookingRepository = new BookingRepository(bookings);
IBookingService bookingService = new BookingService(bookingRepository);
var returnView = new ReturnView(bookingService);

returnView.Run();