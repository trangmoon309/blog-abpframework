using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Permissions
{
    public class PermissionGrantInfoDto
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public string ParentName { get; set; }

        public bool IsGranted { get; set; }

        public List<string> AllowedProviders { get; set; }

        //một permission sẽ có nhiều role đăng kí -> nhiều provider
        public List<ProviderInfoDto> GrantedProviders { get; set; } = new List<ProviderInfoDto>();
    }
}
