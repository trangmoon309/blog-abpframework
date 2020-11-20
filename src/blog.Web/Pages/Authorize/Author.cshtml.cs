using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Identity;
using blog.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.Application.Dtos;

namespace blog.Web.Pages
{
    public class AuthorModel : PageModel
    {
        private readonly IIdentityRoleAppService roleAppService;
        private readonly IAuthorizationService authorization;

        public AuthorModel(IIdentityRoleAppService roleAppService, IAuthorizationService authorization)
        {
            this.roleAppService = roleAppService;
            this.authorization = authorization;
        }

        public ListResultDto<IdentityRoleDto> ListRoles { get; set; } = new ListResultDto<IdentityRoleDto>();

        public async Task<IActionResult> OnGetAsync()
        {
            var result = await authorization.IsGrantedAsync(blogPermissions.Author.ManageRole);
            if(result)
            {
                ListRoles = await roleAppService.GetAllListAsync();
                return Page();
            }
            else
            {
                return RedirectToPage("/Error/AccessDenied", new { errorMesseage = "You don't have permission of Manage Role And Permission!" });
            }
        }
    }
}