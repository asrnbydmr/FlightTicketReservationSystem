using Newtonsoft.Json;
namespace FlightTicketReservationSystem
{
    internal class Airplane
    {
        [JsonProperty("Brand")]
        public string brand { get; set; }
        [JsonProperty("Model")]
        public string model { get; set; }
        [JsonProperty("SerialNumber")]
        public string serialNumber { get; set; }
        [JsonProperty("SeatCapacity")]
        public int seatCapacity { get; set; }
        private static Airplane[] airplanes = new Airplane[4];
        private static void newAirplane(int index, string brand, string model, string serialNumber, int seatCapacity)
        {
            Airplane airplane = new Airplane();
            airplane.brand = brand;
            airplane.model = model;
            airplane.serialNumber = serialNumber;
            airplane.seatCapacity = seatCapacity;
            airplanes[index] = airplane;
        }
        public static void fillAirplanes()
        {
            newAirplane(0, "Airbus", "A319", "THYA319", 264);
            newAirplane(1, "Airbus", "A320", "THYA320", 330);
            newAirplane(2, "Boeing", "737-800", "THYB780", 302);
            newAirplane(3, "Boeing", "737 - 900ER", "THYB79E", 360);
        }
        public static Airplane[] getAirplane() { return airplanes; }
        public static Airplane getAirplane(int index) { return airplanes[index]; }
        public static int getAirplaneCount() { return airplanes.Length; }
    }
}