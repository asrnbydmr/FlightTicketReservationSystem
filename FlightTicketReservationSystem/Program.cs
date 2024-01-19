using System;
namespace FlightTicketReservationSystem
{
    internal class Program
    {
        public static int listCounter;
        static void Main(string[] args)
        {
            FileOperations.fillFiles();
            Console.WriteLine("Flight Ticket Reservation System\n");
            Flight[] flightArray = FileOperations.fileRead<Flight>(FilePath.filepathFlight);
            while (true)
            {
                listCounter = 0;
                Console.WriteLine("Active Flights\n");
                foreach (Flight item in flightArray)
                {
                    if (item.Location.activePassive && item.Airplane.seatCapacity > 0)
                    {
                        ++listCounter;
                        Console.WriteLine($"{listCounter}. Flight:");
                        Console.WriteLine($"Airplane: {item.Airplane.brand} - {item.Airplane.model} - {item.Airplane.serialNumber} - {item.Airplane.seatCapacity}");
                        Console.WriteLine($"Location: {item.Location.country} - {item.Location.city} - {item.Location.airport}");
                        Console.WriteLine($"Date: {item.Date} \n");
                    }
                }
                int chosenFlight = 0;
                chosenFlight = InputControls.intControl(chosenFlight, "Select a Flight: ", 0);
                Flight selectedFlight = flightArray[chosenFlight - 1];
                string firstName = string.Empty, lastName = string.Empty, phoneNumber = string.Empty, gender = string.Empty;
                firstName = InputControls.stringControl(firstName, "Enter First Name: ");
                lastName = InputControls.stringControl(lastName, "Enter Last Name: ");
                int age = 0;
                age = InputControls.intControl(age, "Enter Age: ", 1);
                gender = InputControls.genderControl(gender, "Enter Gender (f/m/o): ");
                phoneNumber = InputControls.phoneNumberControl(phoneNumber, "Enter Phone Number: ");
                --flightArray[chosenFlight].Airplane.seatCapacity;
                Reservation.newReservation(selectedFlight, firstName, lastName, age, gender, phoneNumber);
                Console.Write("Would you like to add a new record? (y/n): ");
                string addMore = Console.ReadLine().Trim().ToUpper();
                if (addMore[0].ToString() == "Y")
                {
                    Console.WriteLine();
                    Console.Clear();
                } else { break; }
            }
            Console.ReadKey();
        }
    }
}