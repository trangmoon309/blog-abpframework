using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Account
{
    public class JwtSetting
    {
        public string Secret { get; set; }
        public TimeSpan TokenLifeTime { get; set; }
    }
}
