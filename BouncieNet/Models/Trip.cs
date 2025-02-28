using GeoJSON.Text;
using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class Trip
    {
        [JsonPropertyName("transactionId")]
        public string TransactionId { get; set; }

        [JsonPropertyName("hardBrakingCount")]
        public int HardBrakingCount { get; set; }

        [JsonPropertyName("hardAccelerationCount")]
        public int HardAccelerationCount { get; set; }

        [JsonPropertyName("distance")]
        public double DistanceInMiles { get; set; }

        // TODO: unsure if
        [JsonPropertyName("gps")]
        public GeoJSON.Text.Geometry.LineString? Gps { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }

        [JsonPropertyName("startOdometer")]
        public double StartOdometer { get; set; }

        [JsonPropertyName("endOdometer")]
        public double EndOdometer { get; set; }

        [JsonPropertyName("averageSpeed")]
        public double AverageSpeedInMph { get; set; }

        [JsonPropertyName("maxSpeed")]
        public double MaxSpeedInMph { get; set; }

        [JsonPropertyName("fuelConsumed")]
        public double FuelConsumedInGallons { get; set; }

        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("totalIdleDuration")]
        public double TotalIdleDuration { get; set; }

        [JsonPropertyName("imei")]
        public string Imei { get; set; }
    }
}