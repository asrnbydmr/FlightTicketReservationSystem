using Newtonsoft.Json;
using System;
namespace FlightTicketReservationSystem
{
    internal class Flight
    {
        [JsonProperty("Airplane")]
        public Airplane Airplane { get; set; }
        [JsonProperty("Location")]
        public Location Location { get; set; }
        [JsonProperty("Date")]
        public DateTime Date { get; set; }
        private static Flight[] flights = new Flight[6];
        public static void fillFlights()
        {
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                Flight flight = new Flight();
                flight.Airplane = Airplane.getAirplane(random.Next(Airplane.getAirplaneCount()));
                flight.Location = Location.getLocation(i);
                DateTime now = DateTime.Now;
                int daysToAdd = random.Next(1, 30);
                flight.Date = now.AddDays(daysToAdd);
                flights[i] = flight;
            }
        }
        public static Flight[] getFlight() { return flights; }
    }
}