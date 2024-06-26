﻿using Microsoft.EntityFrameworkCore;

namespace JwtApiUser_me.Domain.Core
{
    [Keyless]
    public class User
    {
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }
}
