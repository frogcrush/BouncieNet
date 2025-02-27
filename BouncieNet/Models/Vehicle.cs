using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class Vehicle
    {
        [JsonPropertyName("model")]
        public Model Model { get; set; }

        [JsonPropertyName("nickName")]
        public string NickName { get; set; }

        [JsonPropertyName("standardEngine")]
        public string StandardEngine { get; set; }

        [JsonPropertyName("vin")]
        public string Vin { get; set; }

        [JsonPropertyName("imei")]
        public string Imei { get; set; }

        [JsonPropertyName("stats")]
        public Stats Stats { get; set; }
    }
}