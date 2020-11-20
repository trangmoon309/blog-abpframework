using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Permissions
{
    public class PermissionGroupDto
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public List<PermissionGrantInfoDto> Permissions { get; set; } = new List<PermissionGrantInfoDto>();
    }
}
