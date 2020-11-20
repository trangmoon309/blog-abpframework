using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace blog.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        Task<GetPermissionListResultDto> GetPermissionOfARoleAsync([NotNull] string providerName, [NotNull] string providerKey);

        Task UpdatePermissionAsync([NotNull] string providerName, [NotNull] string providerKey, UpdatePermissionsDto input);

        Task<GetPermissionListResultDto> GetAllPermissionAsync();
    }
}
