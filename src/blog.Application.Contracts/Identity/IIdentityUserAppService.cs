using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace blog.Identity
{
    public interface IIdentityUserAppService
    {
        Task<ListResultDto<IdentityRoleDto>> GetRolesAsync(Guid id);

        Task<ListResultDto<IdentityRoleDto>> GetAssignableRolesAsync();

        //Task UpdateRolesAsync(Guid id, IdentityUserUpdateRolesDto input);

        Task<IdentityUserDto> FindByUsernameAsync(string userName);

        Task<IdentityUserDto> FindByEmailAsync(string email);
    }
}
