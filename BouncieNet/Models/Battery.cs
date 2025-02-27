using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class Battery
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("lastUpdated")]
        public DateTime LastUpdated { get; set; }
    }
}