using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class Location
    {
        [JsonPropertyName("lat")]
        public int Lat { get; set; }

        [JsonPropertyName("lon")]
        public int Lon { get; set; }

        [JsonPropertyName("heading")]
        public int Heading { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }
    }
}