using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.PermissionManagement;

namespace blog.Permissions
{
    public class GetPermissionListResultDto
    {
        public string EntityDisplayName { get; set; }

        public List<PermissionGroupDto> Groups { get; set; } = new List<PermissionGroupDto>();
    }
}
