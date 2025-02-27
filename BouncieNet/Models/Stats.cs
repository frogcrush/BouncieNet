using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class Stats
    {
        [JsonPropertyName("localTimeZone")]
        public string LocalTimeZone { get; set; }

        [JsonPropertyName("odometer")]
        public int Odometer { get; set; }

        [JsonPropertyName("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("fuelLevel")]
        public int FuelLevel { get; set; }

        [JsonPropertyName("isRunning")]
        public bool IsRunning { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("mil")]
        public Mil Mil { get; set; }
    }
}