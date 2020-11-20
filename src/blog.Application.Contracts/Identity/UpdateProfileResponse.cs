using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Identity
{
    public class UpdateProfileResponse
    {
        public Volo.Abp.Identity.IdentityUserDto userDto { get; set; }
        public bool IsSuccess { get; set; }
        public string[] ErrorMesseage { get; set; }
    }
}
