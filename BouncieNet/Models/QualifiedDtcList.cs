using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class QualifiedDtcList
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public List<string> Name { get; set; }
    }
}