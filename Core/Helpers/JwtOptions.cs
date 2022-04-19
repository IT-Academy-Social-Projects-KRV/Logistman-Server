namespace Core.Helpers
{
    public class JwtOptions
    {
        public string Issuer { get; set; }
        public string Key { get; set; }
        public int LifeTime { get; set; }
    }
}
