using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class Model
    {
        [JsonPropertyName("make")]
        public string Make { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }
    }
}