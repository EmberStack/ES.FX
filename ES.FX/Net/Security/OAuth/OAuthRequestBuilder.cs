using System.Diagnostics.CodeAnalysis;
using ES.FX.Data.Common;

namespace ES.FX.Net.Security.OAuth
{
    /// <summary>
    /// Strongly typed connection string builder for OAuth authentication requests.
    /// </summary>
    [SuppressMessage("ReSharper", "ExplicitCallerInfoArgument")]
    public class OAuthRequestBuilder : ConnectionStringBuilder
    {
        public OAuthRequestBuilder()
        {
        }

        public OAuthRequestBuilder(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string GrantType
        {
            get => GetValueOrDefault<string>("grant_type");
            set => this["grant_type"] = value;
        }

        public string Username
        {
            get => GetValueOrDefault<string>("username");
            set => this["username"] = value;
        }

        public string Password
        {
            get => GetValueOrDefault<string>("password");
            set => this["password"] = value;
        }

        public string ClientId
        {
            get => GetValueOrDefault<string>("client_id");
            set => this["client_id"] = value;
        }

        public string ClientSecret
        {
            get => GetValueOrDefault<string>("client_secret");
            set => this["client_secret"] = value;
        }

        public string RefreshToken
        {
            get => GetValueOrDefault<string>("refresh_token");
            set => this["refresh_token"] = value;
        }
    }
}
