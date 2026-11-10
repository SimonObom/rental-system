
using RentalSystem.US8.Enums;
using RentalSystem.US8.Models;
using RentalSystem.US8.Repositories;
using RentalSystem.US8.Services;
using RentalSystem.US8.Views;

var bookings = new List<Booking>
{
    new Booking // Checked out
    {
        Id = Guid.Parse("6e4af0f5-172a-4509-adfb-819f0e3b2dc0"),
        EquipmentId = Guid.NewGuid(),
        CustomerId = Guid.NewGuid(),
        StartDate = DateOnly.FromDateTime(DateTime.Today),
        EndDate = DateOnly.FromDateTime(DateTime.Today.AddDays(3)),
        Status = Status.CheckedOut,
        TotalPrice = 500m
    },

    new Booking // Returned
    {
        Id = Guid.Parse("516d344a-4b35-4ebc-a8be-32acafbf23b8"),
        EquipmentId = Guid.NewGuid(),
        CustomerId = Guid.NewGuid(),
        StartDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-5)),
        EndDate = DateOnly.FromDateTime(DateTime.Today.AddDays(-2)),
        Status = Status.Returned,
        TotalPrice = 750m
    }
};

var equipment = new List<Equipment>
{
    new Equipment
    {
        Id = bookings[0].EquipmentId,
        Name = "Slipmaskin",
        Description = "Slipmaskin för golv",
        Category = Category.Slipmaskin,
        Price = 500m
    },

    new Equipment
    {
        Id = bookings[1].EquipmentId,
        Name = "Dammsugare",
        Description = "Dammsugare för byggstädning",
        Category = Category.Dammsugare,
        Price = 250m
    }
};

IBookingRepository bookingRepository = new BookingRepository(bookings);
IEquipmentRepository equipmentRepository = new EquipmentRepository(equipment);

IBookingService bookingService = new BookingService(bookingRepository, equipmentRepository);

var returnView = new ReturnView(bookingService);

returnView.Run();