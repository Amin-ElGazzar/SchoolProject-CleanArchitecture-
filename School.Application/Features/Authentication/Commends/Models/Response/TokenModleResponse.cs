﻿namespace School.Application.Features.Authentication.Commends.Models.Response
{
    public class TokenModleResponse
    {
        public string? Token { get; set; }
        public DateTime ExpiryOn { get; set; }
        public string? Message { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}
