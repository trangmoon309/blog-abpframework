using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Account;
using blog.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;

namespace blog.Web.Pages.Account
{
    public class ManageProfileModel : PageModel
    {

        private readonly IAccountAppService appService;
        private readonly IAuthorizationService authorization;
        private readonly Identity.IdentityRoleAppSerivce roleAppSerivce;

        public ManageProfileModel(IAccountAppService appService, IAuthorizationService authorization, Identity.IdentityRoleAppSerivce roleAppSerivce)
        {
            this.appService = appService;
            this.authorization = authorization;
            this.roleAppSerivce = roleAppSerivce;
        }

        [BindProperty(SupportsGet = true)]
        public IdentityUserDto userDto { get; set; }

        [BindProperty]
        public string newPassword { get; set; } = String.Empty;

        [BindProperty]
        public string newPasswordConfirm { get; set; } = String.Empty;

        public List<blog.Identity.IdentityRoleDto> RoleLists { get; set; }

        [BindProperty]
        public string UserRole { get; set; }

        [BindProperty]
        public string UpdateUserRole { get; set; }
        public async Task<IActionResult> OnGetAsync(Guid userId)
        {
            var result = await authorization.IsGrantedAsync(blogPermissions.User.ManageUser);
            //if(result)
            //{
                RoleLists = await roleAppSerivce.GetAllListAsync2();
                //Get userRole
                UserRole = (await roleAppSerivce.GetUserRole(userId)).Name;
                userDto = await appService.FindByIdAsync(userId);
                userDto.Id = userId;
                return Page();
            //}
            //return RedirectToPage("/Error/AccessDenied", new { errorMesseage = "You don't have permission of Manage Profile!" });
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(!newPassword.IsNullOrEmpty())
            {
                if (!newPasswordConfirm.Equals(newPassword)) return await this.OnGetAsync(userDto.Id);
                await appService.UpdateProfileWithPassword(userDto, newPassword);
            }
            else
            {
                await appService.UpdateProfile(userDto);
                //nếu userRole khác lúc trước thì update userRole
                if (!UserRole.Equals(UpdateUserRole)) await roleAppSerivce.UpdateUserRole(userDto.Id, UpdateUserRole);
            }
            return await this.OnGetAsync(userDto.Id);
        }

    }
}