using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Account
{
    public class LoginAccountDto 
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
