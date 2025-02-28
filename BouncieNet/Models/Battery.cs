using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BouncieNet.Models
{
    public class Battery
    {
        [JsonPropertyName("status")]
        public BatteryStateEnum Status { get; set; }

        [JsonPropertyName("lastUpdated")]
        public DateTime LastUpdated { get; set; }
    }

    public enum BatteryStateEnum
    {
        [EnumMember(Value = "normal")]
        Normal,

        [EnumMember(Value = "low")]
        Low,

        [EnumMember(Value = "critical")]
        Critical
    }
}