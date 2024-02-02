using System.Globalization;
using exemplo_sem_interface.Entities;
using exemplo_sem_interface.Services;

Console.WriteLine("Enter rental data");
Console.WriteLine("Car Model: ");
string model = Console.ReadLine();
Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);


Console.WriteLine("Enter price per Hour: ");
double hour = double.Parse(Console.ReadLine());
Console.WriteLine("Enter price per Day: ");
double day = double.Parse(Console.ReadLine());

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalServices rentalServices = new RentalServices(hour, day);
rentalServices.PorcessInvoice(carRental);

Console.WriteLine("Invoice: ");
Console.WriteLine(carRental.Invoice);