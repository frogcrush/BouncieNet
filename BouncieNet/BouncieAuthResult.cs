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

        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public int ExpiresIn { get; set; }

        [JsonIgnore]
        public DateTime Expiry => _creationTime.AddSeconds(ExpiresIn);
    }
}