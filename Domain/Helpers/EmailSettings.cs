using UiPath.Mail;

namespace Domain.Helpers
{
    public static class EmailSettings
    {
        public static readonly string ServerName = "c1105519.sgvps.net";
        public static readonly int Port = 993;
        public static readonly string Email = "application@checkmigcolombia.us";
        public static readonly string Password = "1][1}ei\\e5N5";
        public static readonly SecureSocketEncryption SecureConnections = SecureSocketEncryption.SslOnConnect;
        public static readonly int Timeout = 6000;
    }
}