using ES.FX.Data.Common;

namespace ES.FX.Net.Security
{
    /// <summary>
    /// Strongly typed connection string builder for credentails.
    /// Provides support for basic credentails and client credentials.
    /// </summary>
    public class CredentialsStringBuilder : ConnectionStringBuilder
    {
        public CredentialsStringBuilder()
        {
        }

        public CredentialsStringBuilder(string connectionString)
        {
            ConnectionString = connectionString;
        }


        public string Username
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }

        public string Password
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }

        public string ClientId
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }

        public string ClientSecret
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }

        public string Realm
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }
    }
}
