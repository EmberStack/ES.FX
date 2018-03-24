using System.Net;
using System.Net.Mail;

namespace ES.FX.Net.Mail
{
    /// <summary>
    ///     Collection of extension methods for <see cref="SmtpClient"></see>
    /// </summary>
    public static class SmtpClientExtensions
    {
        /// <summary>
        ///     Applies connection settings from a connection string using a <see cref="SmtpConnectionStringBuilder"></see>
        /// </summary>
        public static void Configure(this SmtpClient smtpClient, string connectionString)
        {
            var connectionStringBuilder = new SmtpConnectionStringBuilder(connectionString);
            smtpClient.Configure(connectionStringBuilder);
        }


        /// <summary>
        ///     Applies connection settings from a connection string using a <see cref="SmtpConnectionStringBuilder"></see>
        /// </summary>
        public static void Configure(this SmtpClient smtpClient,
            SmtpConnectionStringBuilder smtpConnectionStringBuilder)
        {
            smtpClient.Host = smtpConnectionStringBuilder.Host;
            smtpClient.Port = smtpConnectionStringBuilder.Port;
            smtpClient.EnableSsl = smtpConnectionStringBuilder.EnableSsl;
            smtpClient.Credentials = new NetworkCredential(smtpConnectionStringBuilder.Username,
                smtpConnectionStringBuilder.Password);
        }
    }
}