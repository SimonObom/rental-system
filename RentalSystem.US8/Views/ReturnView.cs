using RentalSystem.US8.Enums;
using RentalSystem.US8.Services;

namespace RentalSystem.US8.Views;

public class ReturnView(IBookingService bookingService)
{
    public void Run()
    {
        Console.WriteLine("1. Använd ordernummer för pågående bokning");
        Console.WriteLine("2. Använd ordernummer för återlämnad bokning");
        Console.WriteLine("3. Använd ordernummer som saknas");
        Console.WriteLine("4. Använd ogiltigt ordernummer");
        Console.Write("Välj scenario: ");

        var orderNumber = Console.ReadLine() switch
        {
            "1" => "6e4af0f5-172a-4509-adfb-819f0e3b2dc0",
            "2" => "516d344a-4b35-4ebc-a8be-32acafbf23b8",
            "3" => "15026360-8605-4856-9910-96fdeeea613f",
            "4" => "123",
            _ => string.Empty
        };

        if (!Guid.TryParse(orderNumber, out var id))
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
