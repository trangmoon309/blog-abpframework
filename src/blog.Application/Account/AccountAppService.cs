using Abp.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;
using Volo.Abp.Identity;
using IdentityUser = Volo.Abp.Identity.IdentityUser;
using blog.Account;
using Volo.Abp.Users;
using blog.Identity;
using Volo.Abp.Users;

namespace blog.Account
{
    public class AccountAppService : IdentityAppServiceBase, IAccountAppService
    {
        protected IdentityUserManager UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; set; }
        public AccountAppService(IdentityUserManager userManager, SignInManager<IdentityUser> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public async Task LoginAsync(Volo.Abp.Identity.IdentityUserDto userDto)
        {
            var user = await UserManager.FindByIdAsync(userDto.Id.ToString());
            await SignInManager.SignInAsync(user, false);
        }

        public async Task<Volo.Abp.Identity.IdentityUserDto> FindByIdAsync(Guid id)
        {
            var identityUser = await UserManager.GetByIdAsync(id);
            var identityUserDto = new Volo.Abp.Identity.IdentityUserDto()
            {
                UserName = identityUser.UserName,
                Name = identityUser.Name,
                Email = identityUser.Email,
                PhoneNumber = identityUser.PhoneNumber,
            };
            return identityUserDto;
        }

        public async Task<bool> UpdateProfileWithPassword(Volo.Abp.Identity.IdentityUserDto userDto, string newPassword)
        {
            var user = await UserManager.FindByIdAsync(userDto.Id.ToString());
            var isExistPassword = await UserManager.CheckPasswordAsync(user, newPassword);

            if (!isExistPassword)
            {
                var token = await UserManager.GeneratePasswordResetTokenAsync(user);
                await UserManager.ResetPasswordAsync(user, token, newPassword);
            }
            user.Name = userDto.Name;
            await UserManager.UpdateAsync(user);
            return true;
        }

        public async Task<bool> CheckCurrentPassword(blog.Identity.ChangePasswordRequest changePasswordRequest)
        {
            var user = await UserManager.GetByIdAsync(CurrentUser.GetId());
            var isRightPassword = await UserManager.CheckPasswordAsync(user, changePasswordRequest.CurrentPassword);
            return isRightPassword;
        }

        public async Task<bool> ChangePassWord(ChangePasswordRequest changePasswordRequest)
        {
            var currentUser = await UserManager.GetByIdAsync(CurrentUser.GetId());
            var isRightPassword = await UserManager.CheckPasswordAsync(currentUser, changePasswordRequest.CurrentPassword);
            if (!isRightPassword) return false;

            if (!changePasswordRequest.NewPassword.IsNullOrEmpty() && changePasswordRequest.ConfirmNewPassword.Equals(changePasswordRequest.NewPassword))
            {
                var userDto = ObjectMapper.Map<IdentityUser, Volo.Abp.Identity.IdentityUserDto>(currentUser);
                  await UpdateProfileWithPassword(userDto, changePasswordRequest.NewPassword);
                return true;
            }

            return false;
        }

        public async Task<bool> UpdateProfile(Volo.Abp.Identity.IdentityUserDto userDto)
        {
            var user = await UserManager.GetByIdAsync(CurrentUser.GetId());
            user.Name = userDto.Name;
            (await UserManager.SetUserNameAsync(user, userDto.UserName)).CheckErrors();
            await UserManager.SetEmailAsync(user, userDto.Email);
            user.Surname = user.Name;
            user.SetPhoneNumber(userDto.PhoneNumber, true);
            await UserManager.UpdateAsync(user);
            return true;
        }

        public async Task<Volo.Abp.Identity.IdentityUserDto> GetAsync()
        {
            var currentUser = await UserManager.GetByIdAsync(CurrentUser.GetId());
            return ObjectMapper.Map<IdentityUser, Volo.Abp.Identity.IdentityUserDto>(currentUser);
        }

        public async Task<bool> UpdateProfile(UpdateProfileDto userDto)
        {
            var user = await UserManager.GetByIdAsync(CurrentUser.GetId());
            if (!userDto.Name.IsNullOrEmpty()) user.Name = userDto.Name;
            if(!userDto.Email.IsNullOrEmpty()) await UserManager.SetEmailAsync(user, userDto.Email);
            if (!userDto.UserName.IsNullOrEmpty()) (await UserManager.SetUserNameAsync(user, userDto.UserName)).CheckErrors();
            if (!userDto.Surname.IsNullOrEmpty()) user.Surname = user.Name;
            if (!userDto.PhoneNumber.IsNullOrEmpty()) user.SetPhoneNumber(userDto.PhoneNumber, true);
            await UserManager.UpdateAsync(user);
            return true;
        }
    }
}
