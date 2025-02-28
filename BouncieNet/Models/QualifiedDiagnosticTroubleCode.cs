using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class QualifiedDiagnosticTroubleCode
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("name")]
        public List<string> Name { get; set; }
    }
}