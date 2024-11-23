namespace School.Application.Features.Authentication.Commends.Models.Response
{
    public class TokenModleResponse
    {
        public string? AccessToken { get; set; }
        public bool IsAuthenticated { get; set; }
        public string? Message { get; set; }
        public RefreshTokens RefreshTokens { get; set; }
    }

    public class RefreshTokens
    {
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExpires { get; set; }

    }
}
