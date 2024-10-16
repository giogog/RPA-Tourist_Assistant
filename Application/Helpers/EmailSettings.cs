using UiPath.Mail;

namespace Tourist_Assistant.Application.Helpers
{
    public static class EmailSettings
    {
        public static readonly string ServerName = "ServerName";
        public static readonly int Port = 993;
        public static readonly string Email = "Email";
        public static readonly string Password = "Password";
        public static readonly SecureSocketEncryption SecureConnections = SecureSocketEncryption.SslOnConnect;
        public static readonly int Timeout = 6000;
    }
}