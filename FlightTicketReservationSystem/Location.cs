using Newtonsoft.Json;
namespace FlightTicketReservationSystem
{
    internal class Location
    {
        [JsonProperty("Country")]
        public string country { get; set; }
        [JsonProperty("City")]
        public string city { get; set; }
        [JsonProperty("Airport")]
        public string airport { get; set; }
        [JsonProperty("ActivePassive")]
        public bool activePassive { get; set; }
        private static Location[] locations = new Location[6];
        private static void newLocation(int index, string country, string city, string airport, bool activePassive)
        {
            Location location = new Location();
            location.country = country;
            location.city = city;
            location.airport = airport;
            location.activePassive = activePassive;
            locations[index] = (location);
        }
        public static void fillLocations()
        {
            newLocation(0, "Turkey", "Ankara", "Ankara Esenboğa Havalimanı", true);
            newLocation(1, "Turkey", "Antalya", "Antalya Havalimanı", false);
            newLocation(2, "Turkey", "Bursa", "Bursa Yenişehir Havalimanı", true);
            newLocation(3, "Turkey", "Denizli", "Denizli Çardak Havalimanı", false);
            newLocation(4, "Turkey", "İstanbul", "Atatürk Havalimanı", true);
            newLocation(5, "Turkey", "İzmir", "İzmir Adnan Menderes Havalimanı", true);
        }
        public static Location[] getLocation() { return locations; }
        public static Location getLocation(int index) { return locations[index]; }
    }
}