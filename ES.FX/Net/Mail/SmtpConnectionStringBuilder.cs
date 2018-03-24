using System.Net;
using System.Net.Mail;
using ES.FX.Data.Common;

namespace ES.FX.Net.Mail
{
    /// <summary>
    ///     Connection string builder for <see cref="SmtpClient"></see>.
    /// </summary>
    public class SmtpConnectionStringBuilder : ConnectionStringBuilder
    {
        public SmtpConnectionStringBuilder()
        {
        }

        public SmtpConnectionStringBuilder(string connectionString)
        {
            ConnectionString = connectionString;
        }

        /// <summary>
        ///     A <see cref="string"></see> that contains the name or IP address of the host computer used for SMTP transactions.
        /// </summary>
        public string Host
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }

        /// <summary>
        ///     An <see cref="int"></see> greater than zero that contains the port to be used on host.
        /// </summary>
        public int Port
        {
            get => GetValueOrDefault<int>();
            set => SetValue(value);
        }

        /// <summary>
        ///     Specify whether the <see cref="SmtpClient"></see> uses SSL to encrypt the connection.
        ///     true if the <see cref="SmtpClient"></see> uses SSL; otherwise, false. The default is false.
        /// </summary>
        public bool EnableSsl
        {
            get => GetValueOrDefault<bool>();
            set => SetValue(value);
        }


        /// <summary>
        ///     Specify the <see cref="string"></see> used as Username for <see cref="NetworkCredential"></see>
        ///     authentication
        /// </summary>
        public string Username
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }

        /// <summary>
        ///     Specify the <see cref="string"></see> used as Password for <see cref="NetworkCredential"></see>
        ///     authentication
        /// </summary>
        public string Password
        {
            get => GetValueOrDefault<string>();
            set => SetValue(value);
        }
    }
}