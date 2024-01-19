using System.IO;
using Newtonsoft.Json;
namespace FlightTicketReservationSystem
{
    internal class FileOperations
    {
        private const string folderName = "files";
        private static void folderExists()
        {
            if (!Directory.Exists(folderName)) { Directory.CreateDirectory(folderName); }
        }
        private static bool fileExists(string filePath)
        {
            folderExists();
            if (!File.Exists(filePath)) { File.Create(filePath).Close(); }
            return true;
        }
        public static T[] fileRead<T>(string filePath)
        {
            if (fileExists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<T[]>(jsonData);
            } else { return null; }
        }
        public static bool fileWrite<T>(string filePath, T[] data)
        {
            if (fileExists(filePath))
            {
                string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
                File.WriteAllText(filePath, jsonData);
                return true;
            } else { return false; }
        }
        private static void fillAirplaneFile()
        {
            Airplane.fillAirplanes();
            fileWrite(FilePath.filepathAirplane, Airplane.getAirplane());
        }
        private static void fillLocationFile()
        {
            Location.fillLocations();
            fileWrite(FilePath.filepathLocation, Location.getLocation());
        }
        private static void fillFlightFile()
        {
            Flight.fillFlights();
            fileWrite(FilePath.filepathFlight, Flight.getFlight());
        }
        public static void fillFiles() { fillAirplaneFile(); fillLocationFile(); fillFlightFile(); }
    }
}