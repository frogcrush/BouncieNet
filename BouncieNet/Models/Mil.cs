using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class Mil
    {
        [JsonPropertyName("milOn")]
        public bool MilOn { get; set; }

        [JsonPropertyName("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [JsonPropertyName("qualifiedDtcList")]
        public List<QualifiedDtcList> QualifiedDtcList { get; set; }

        [JsonPropertyName("battery")]
        public Battery Battery { get; set; }
    }
}