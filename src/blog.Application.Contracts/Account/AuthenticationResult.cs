using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Account
{
    public class AuthenticationResult
    {
        public string Token { get; set; }
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
        //public RefreshToken RefreshToken { get; set; }
    }
}
