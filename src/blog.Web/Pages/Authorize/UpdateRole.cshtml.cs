using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Web.Pages.Authorize
{
    public class UpdateRoleModel : PageModel
    {
        private readonly IPermissionAppService permissionAppService;
        private readonly IAuthorizationService authorization;

        public UpdateRoleModel(IPermissionAppService permissionAppService, IAuthorizationService authorization)
        {
            this.permissionAppService = permissionAppService;
            this.authorization = authorization;
        }

        public GetPermissionListResultDto permissionGroupList { get; set; }

        public UpdatePermissionsDto updatedPermissionsDto { get; set; } 

        [BindProperty]
        public string ProviderName { get; set; }

        [BindProperty]
        public string ProviderKey { get; set; }

        [BindProperty]
        public List<PermissionGroupDto> permissionGroupDto { get; set; } = new List<PermissionGroupDto>();

        public async Task<IActionResult> OnGetAsync(string providerName, string providerKey)
        {
            var result = await authorization.IsGrantedAsync(blogPermissions.Author.ManageRole);
            if(result)
            {
                permissionGroupList = await permissionAppService.GetPermissionOfARoleAsync(providerName, providerKey);
                foreach (var group in permissionGroupList.Groups)
                {
                    if (group.Name.Equals("blogproject")) permissionGroupDto.Add(group);
                }
                ProviderName = providerName;
                ProviderKey = providerKey;
                return Page();
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            updatedPermissionsDto = new UpdatePermissionsDto();
            foreach (var group in permissionGroupDto)
            {
                foreach (var perItem in group.Permissions)
                {
                    UpdatePermissionDto item = new UpdatePermissionDto();
                    item.Name = perItem.Name;
                    item.IsGranted = perItem.IsGranted;
                    updatedPermissionsDto.Permissions.Add(item);
                }
            }

            await permissionAppService.UpdatePermissionAsync(ProviderName, ProviderKey, updatedPermissionsDto);
            return Page();
        }
    }
}