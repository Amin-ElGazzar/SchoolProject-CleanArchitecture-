namespace School.Application.Common.Models
{
    public class Jwt
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string Key { get; set; }
        public double AccessTokenTime { get; set; }
        public double RefreshTokenTime { get; set; }
    }
}
