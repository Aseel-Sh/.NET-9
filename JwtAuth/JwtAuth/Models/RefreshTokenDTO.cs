﻿namespace JwtAuth.Models
{
    public class RefreshTokenDTO
    {
        public Guid UserId { get; set; }
        public required string RefreshToken { get; set; }
    }
}
