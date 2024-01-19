using Newtonsoft.Json;
using System.Collections;
namespace FlightTicketReservationSystem
{
    internal class Reservation
    {
        [JsonProperty("Flight")]
        public Flight flight { get; set; }
        [JsonProperty("FirstName")]
        public string firstName { get; set; }
        [JsonProperty("LastName")]
        public string lastName { get; set; }
        [JsonProperty("Age")]
        public int age { get; set; }
        [JsonProperty("Gender")]
        public string gender { get; set; }
        [JsonProperty("PhoneNumber")]
        public string phoneNumber { get; set; }
        private static ArrayList reservations = new ArrayList();
        public static void newReservation(Flight flight, string firstName, string lastName, int age, string gender, string phoneNumber)
        {
            Reservation reservation = new Reservation();
            reservation.flight = flight;
            reservation.firstName = firstName;
            reservation.lastName = lastName;
            reservation.age = age;
            reservation.gender = gender;
            reservation.phoneNumber = phoneNumber;
            reservations.Add(reservation);
            FileOperations.fileWrite(FilePath.filepathRezervation, getReservation());
        }
        public static Reservation[] getReservation()
        {
            if (reservations != null)
            {
                Reservation[] arrayReservations = new Reservation[reservations.Count];
                int counter = 0;
                foreach (Reservation reservation in reservations)
                {
                    arrayReservations[counter] = (Reservation)reservations[counter];
                    counter++;
                } return arrayReservations;
            } return null;
        }
    }
}