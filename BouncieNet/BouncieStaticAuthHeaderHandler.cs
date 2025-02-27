using Microsoft.Extensions.Options;
using System.Net.Http.Json;

namespace BouncieNet
{
    public class BouncieStaticAuthHeaderHandler : DelegatingHandler
    {
        private BouncieConfiguration _config;
        private BouncieAuthResult? _previousResult;

        public BouncieStaticAuthHeaderHandler(IOptions<BouncieConfiguration> config)
        {
            _config = config.Value;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var token = await GetAuthToken(cancellationToken);
            request.Headers.Add("Authorization", token);
            return await base.SendAsync(request, cancellationToken);
        }

        private async Task<string> GetAuthToken(CancellationToken token)
        {
            if (_previousResult != null)
            {
                if (DateTime.UtcNow < DateTimeOffset.FromUnixTimeSeconds(_previousResult.ExpiresIn))
                {
                    return _previousResult.AccessToken;
                }
            }

            if (_config == null)
            {
                throw new Exception("Configuration not set");
            }

            _config.EnsureValid();

            var result = await base.SendAsync(new HttpRequestMessage(HttpMethod.Post, "https://auth.bouncie.com/oauth/token")
            {
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "client_id", _config.ClientId },
                    { "client_secret", _config.ClientSecret },
                    { "redirect_uri", _config.RedirectUri },
                    { "code", _config.AuthorizationCode },
                    { "grant_type", "authorization_code" }
                })
            }, token);

            if (!result.IsSuccessStatusCode)
            {
                throw new Exception("Failed to get auth token");
            }

            var content = await result.Content.ReadFromJsonAsync<BouncieAuthResult>(cancellationToken: token) ?? throw new Exception("Could not deserialize auth token.");
            _previousResult = content;
            return content.AccessToken;
        }
    }
}