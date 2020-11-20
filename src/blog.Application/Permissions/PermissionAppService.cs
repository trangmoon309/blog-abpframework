using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.PermissionManagement;
using Volo.Abp.Authorization.Permissions;
using Microsoft.AspNetCore.Identity;

namespace blog.Permissions
{
    public class PermissionAppService : ApplicationService, IPermissionAppService
    {
        protected IPermissionManager PermissionManager { get; }
        protected IPermissionDefinitionManager PermissionDefinitionManager { get; }

        public PermissionAppService(IPermissionManager permissionManager, IPermissionDefinitionManager permissionDefinitionManager)
        {
            PermissionManager = permissionManager;
            PermissionDefinitionManager = permissionDefinitionManager;
        }

        //provider key = role Name
        public async Task<GetPermissionListResultDto> GetPermissionOfARoleAsync(string providerName,string providerKey)
        {
            var result = new GetPermissionListResultDto();
            foreach (var group in PermissionDefinitionManager.GetGroups())
            {
                var groupDto = new PermissionGroupDto
                {
                    Name = group.Name,
                    DisplayName = group.DisplayName.Localize(StringLocalizerFactory),
                    Permissions = new List<PermissionGrantInfoDto>()
                };

                foreach(var perItem in group.GetPermissionsWithChildren())
                {
                    var grantInfoDto = new PermissionGrantInfoDto
                    {
                        Name = perItem.Name,
                        DisplayName = perItem.DisplayName.Localize(StringLocalizerFactory),
                        ParentName = perItem.Parent?.Name,
                        AllowedProviders = perItem.Providers,
                    };

                    var grantInfo = await PermissionManager.GetAsync(perItem.Name, providerName, providerKey);

                    //kiểm tra xem với provider key và name này thì permission đã được grant chưa?
                    grantInfoDto.IsGranted = grantInfo.IsGranted;

                    foreach (var provider in grantInfo.Providers)
                    {
                        grantInfoDto.GrantedProviders.Add(new ProviderInfoDto
                        {
                            ProviderName = provider.Name,
                            ProviderKey = provider.Key,
                        });
                    }
                    groupDto.Permissions.Add(grantInfoDto);
                }
                result.Groups.Add(groupDto);
            }
            return result;   
        }

        public async Task UpdatePermissionAsync(string providerName, string providerKey, UpdatePermissionsDto input)
        {
            foreach (var permissionDto in input.Permissions)
            {
                await PermissionManager.SetAsync(permissionDto.Name, providerName, providerKey, permissionDto.IsGranted);
            }
        }

        public async Task<GetPermissionListResultDto> GetAllPermissionAsync()
        {
            var result = new GetPermissionListResultDto();
            foreach (var group in PermissionDefinitionManager.GetGroups())
            {
                var groupDto = new PermissionGroupDto
                {
                    Name = group.Name,
                    DisplayName = group.DisplayName.Localize(StringLocalizerFactory),
                    Permissions = new List<PermissionGrantInfoDto>()
                };

                foreach(var perItem in group.GetPermissionsWithChildren())
                {
                    var grantInfoDto = new PermissionGrantInfoDto
                    {
                        Name = perItem.Name,
                        DisplayName = perItem.DisplayName.Localize(StringLocalizerFactory),
                        ParentName = perItem.Parent?.Name,
                        AllowedProviders = perItem.Providers,
                    };  
                    groupDto.Permissions.Add(grantInfoDto);
                }
                result.Groups.Add(groupDto);
            }
            return result;
        }
    }
}
