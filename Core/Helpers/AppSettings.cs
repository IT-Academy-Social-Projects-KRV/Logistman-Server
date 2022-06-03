namespace Core.Helpers
{
    public class AppSettings
    {
        public string JWTSecret { get; set; }

        public string SendGridKey { get; set; }

        public string SendGridEmail { get; set; }

        public string SendGridSenderName { get; set; }
    }
}
