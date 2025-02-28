using System.Text.Json.Serialization;

namespace BouncieNet
{
    internal class BouncieAuthResult
    {
        public BouncieAuthResult(string accessToken, string tokenType, int expiresIn)
        {
            AccessToken = accessToken;
            TokenType = tokenType;
            ExpiresIn = expiresIn;
            _creationTime = DateTime.Now;
        }

        [JsonIgnore]
        private DateTime _creationTime;

        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonIgnore]
        public DateTime Expiry => _creationTime.AddSeconds(ExpiresIn);
    }
}