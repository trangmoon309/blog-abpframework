using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Permissions
{
    public class UpdatePermissionDto
    {
        public string Name { get; set; }

        public bool IsGranted { get; set; }
    }
}
