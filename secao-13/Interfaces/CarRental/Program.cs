using System.Globalization;
using CarRentalProject.Entities;
using CarRentalProject.Services;

Console.WriteLine("Enter rental data");
Console.Write("Car model: ");
string model = Console.ReadLine();
Console.Write("Pickup (MM/dd/yyyy HH:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (MM/dd/yyyy HH:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine());
Console.Write("Enter price per day: ");
double day = double.Parse(Console.ReadLine());

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
rentalService.ProcessInvoice(carRental);
Console.WriteLine("\nInvoice");
Console.WriteLine(carRental.Invoice);