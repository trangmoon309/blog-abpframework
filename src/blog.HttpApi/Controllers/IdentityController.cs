using blog.Account;
using blog.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Users;

namespace blog.Controllers
{
    [Route("api/identity")]
    public class IdentityController : AbpController
    {
        protected IIdentityAppService identityAppService { get; }
        protected IFacebookAuthService facebookAuthService { get; }
        protected IAccountAppService accountAppService { get; }



        public IdentityController(IIdentityAppService identityAppService, IFacebookAuthService facebookAuthService, IAccountAppService accountAppService)
        {
            this.identityAppService = identityAppService;
            this.facebookAuthService = facebookAuthService;
            this.accountAppService = accountAppService;
        }

        [HttpPost]
        [Route("login")]
        public virtual Task<AuthenticationResult> LoginAsync(LoginDto input)
        {
            var result = identityAppService.LoginAsync(input);
            var x = CurrentUser.GetId();
            return result;
        }

        //EAAK4ZANJD3ZAcBAGov1O6tt78rJ42AmeHLVWZCjZABE0DEkIx04FWRZCmjXgGKCH6cf9tX1bFtK0rlheOZCUoYfa7mB05UYZAHdvpwSdoLm5Py4kyC4B4dZCU7fr4HKpH7ZBCNYFGL0QHg5lwNLNwjavado0RBHL4jMNTKmkubrWj4eATalPvZBPbzwdJG5xggrigtHDNw98390wZDZD
        [HttpPost]
        [Route("facebookLogin")]
        public virtual async Task<AuthenticationResult> FacebookLogin(string accessToken)
        {
            var userInfo = await facebookAuthService.GetUserInfoAsync(accessToken);
            return await identityAppService.ExternalLogin(userInfo);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet]
        public virtual async Task<Volo.Abp.Identity.IdentityUserDto> GetProfile()
        {
            var user = await accountAppService.GetAsync();
            return user;
        }

        [HttpPut]
        [Route("updateprofile")]
        public virtual async Task<UpdateProfileResponse> UpdateProfile(UpdateProfileDto userDto)
        {
            var result = await accountAppService.UpdateProfile(userDto);
            var response = new UpdateProfileResponse
            {
                userDto = await accountAppService.GetAsync()
            };
            if (result) response.IsSuccess = true;
            else
            {
                response.IsSuccess = false;
                response.ErrorMesseage = new string[] { "Update Failed!" };
            }
            return response;
        }

        [HttpPut]
        [Route("changepassword")]
        public virtual async Task<UpdateProfileResponse> ChangePassword(ChangePasswordRequest request)
        {
            var response = new UpdateProfileResponse();
            var result = await accountAppService.ChangePassWord(request);
            if (!result)
            {
                response.IsSuccess = false;
                response.ErrorMesseage = new string[] { "Current password don't match/ confirm password don't match!" };
                return response;
            }
            response.IsSuccess = true;
            response.userDto = await accountAppService.GetAsync();
            return response;
        }
    }
}
