using RentalSystem.US8.Enums;
using RentalSystem.US8.Services;

namespace RentalSystem.US8.Views;

public class ReturnView(IBookingService bookingService)
{
    public void Run()
    {
        Console.Write("Ange ordernummer: ");

        if (!Guid.TryParse(Console.ReadLine(), out var id))
        {
            Console.WriteLine("Ordernumret måste vara ett giltigt ordernummer.");
            return;
        }

        var booking = bookingService.GetBooking(id);

        if (booking is null)
        {
            Console.WriteLine("Bokningen hittades inte.");
            return;
        }

        Console.WriteLine($"Ordernummer: {booking.Id}");
        Console.WriteLine($"Startdatum: {booking.StartDate}");
        Console.WriteLine($"Slutdatum: {booking.EndDate}");

        if (booking.Status == Status.CheckedOut)
        {
            Console.WriteLine("Uthyrningen pågår.");
        }
        else
        {
            Console.WriteLine($"Uthyrningen pågår inte. Status: {booking.Status}");
        }
    }
}
