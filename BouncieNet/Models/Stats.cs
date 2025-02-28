using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class Stats
    {
        [JsonPropertyName("localTimeZone")]
        public string LocalTimeZone { get; set; }

        [JsonPropertyName("odometer")]
        public double Odometer { get; set; }

        [JsonPropertyName("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("fuelLevel")]
        public double FuelLevel { get; set; }

        [JsonPropertyName("isRunning")]
        public bool IsRunning { get; set; }

        [JsonPropertyName("speed")]
        public double Speed { get; set; }

        [JsonPropertyName("mil")]
        public MalfunctionIndicatorLight MalfunctionIndicatorLight { get; set; }
    }
}