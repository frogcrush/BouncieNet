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
        public int Distance { get; set; }

        [JsonPropertyName("gps")]
        public string Gps { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("endTime")]
        public DateTime EndTime { get; set; }

        [JsonPropertyName("startOdometer")]
        public int StartOdometer { get; set; }

        [JsonPropertyName("endOdometer")]
        public int EndOdometer { get; set; }

        [JsonPropertyName("averageSpeed")]
        public int AverageSpeed { get; set; }

        [JsonPropertyName("maxSpeed")]
        public int MaxSpeed { get; set; }

        [JsonPropertyName("fuelConsumed")]
        public int FuelConsumed { get; set; }

        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("totalIdleDuration")]
        public int TotalIdleDuration { get; set; }

        [JsonPropertyName("imei")]
        public string Imei { get; set; }
    }
}
