using blog.Account;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace blog.Identity
{
    public interface IIdentityAppService
    {
        Task<AuthenticationResult> LoginAsync(LoginDto input);
        Task<AuthenticationResult> ExternalLogin(FacebookUserInfoResult userInfo);

    }
}
