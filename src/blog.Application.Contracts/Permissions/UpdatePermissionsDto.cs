using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Permissions
{
    public class UpdatePermissionsDto
    {
        public List<UpdatePermissionDto> Permissions { get; set; } = new List<UpdatePermissionDto>();
    }
}
