using Aula143.Entities;
using Aula143.Entities.Exceptions;


try
{
    Console.Write("Room number: ");
    int rNumber = int.Parse(Console.ReadLine());
    Console.Write("Check-in date (DD/MM/YYYY): ");
    DateTime cIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (DD/MM/YYYY): ");
    DateTime cOut = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(rNumber, cIn, cOut);
    Console.WriteLine("Reservation: " + reservation);

    Console.WriteLine();
    Console.WriteLine("Enter data to update the reservation: ");
    Console.Write("Check-in date (DD/MM/YYYY): ");
    cIn = DateTime.Parse(Console.ReadLine());
    Console.Write("Check-out date (DD/MM/YYYY): ");
    cOut = DateTime.Parse(Console.ReadLine());

    reservation.UpdateDates(cIn, cOut);
    Console.WriteLine("Reservation: " + reservation);
}
catch (DomainException e)
{
    Console.WriteLine("Error in reservation: " + e.Message);
}