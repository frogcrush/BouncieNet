using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class MalfunctionIndicatorLight
    {
        [JsonPropertyName("milOn")]
        public bool IndicatorLightOn { get; set; }

        [JsonPropertyName("lastUpdated")]
        public DateTime LastUpdated { get; set; }

        [JsonPropertyName("qualifiedDtcList")]
        public List<QualifiedDiagnosticTroubleCode> QualifiedDiagnosticCodeList { get; set; }

        [JsonPropertyName("battery")]
        public Battery Battery { get; set; }
    }
}