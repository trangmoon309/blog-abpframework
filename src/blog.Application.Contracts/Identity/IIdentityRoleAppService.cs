using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;

namespace blog.Identity
{
    public interface IIdentityRoleAppService 
    {
        Task<ListResultDto<IdentityRoleDto>> GetAllListAsync();
        Task<List<IdentityRoleDto>> GetAllListAsync2();
        Task<IdentityRoleDto> GetAsync(Guid id);
        Task<PagedResultDto<IdentityRoleDto>> GetListAsync(GetIdentityRolesInput input);
        Task<IdentityRoleDto> UpdateAsync(Guid id, IdentityRoleUpdateDto input);
        Task<IdentityRoleDto> GetUserRole(Guid userId);

    }
}
