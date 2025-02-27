using System.Diagnostics.CodeAnalysis;

namespace BouncieNet
{
    public class BouncieConfiguration
    {
        public string? ClientId { get; set; }
        public string? ClientSecret { get; set; }
        public string? RedirectUri { get; set; }

        public string? AuthorizationCode { get; set; }

        [MemberNotNull(nameof(ClientId), nameof(ClientSecret), nameof(RedirectUri), nameof(AuthorizationCode))]
        internal void EnsureValid()
        {
            if (string.IsNullOrWhiteSpace(ClientId))
            {
                throw new InvalidOperationException("ClientId must be set");
            }

            if (string.IsNullOrWhiteSpace(ClientSecret))
            {
                throw new InvalidOperationException("ClientSecret must be set");
            }

            if (string.IsNullOrWhiteSpace(RedirectUri))
            {
                throw new InvalidOperationException("RedirectUri must be set");
            }

            if (string.IsNullOrWhiteSpace(AuthorizationCode))
            {
                throw new InvalidOperationException("AuthorizationCode must be set");
            }
        }
    }
}