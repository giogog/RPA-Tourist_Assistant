using UiPath.Mail;

namespace Domain.Helpers
{
    public static class EmailSettings
    {
        public static readonly string ServerName = "mail.dominicanrepubliceticket.us";
        public static readonly int Port = 993;
        public static readonly string Email = "application@dominicanrepubliceticket.us";
        public static readonly string Password = "3A+3d+5e`@n6";
        public static readonly SecureSocketEncryption SecureConnections = SecureSocketEncryption.SslOnConnect;
        public static readonly int Timeout = 6000;
    }
}