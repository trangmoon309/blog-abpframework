using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace blog.Identity
{
    public class GetIdentityRolesInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
