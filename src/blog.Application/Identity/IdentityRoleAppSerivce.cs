using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Identity;
using IdentityRole = Volo.Abp.Identity.IdentityRole;

namespace blog.Identity
{
    public class IdentityRoleAppSerivce : IdentityAppServiceBase, IIdentityRoleAppService
    {
        protected IdentityRoleManager RoleManager { get; }
        protected IIdentityRoleRepository RoleRepository { get; }
        protected IdentityUserManager UserManager { get; }


        public IdentityRoleAppSerivce(IdentityRoleManager roleManager, IIdentityRoleRepository roleRepository, IdentityUserManager userManager)
        {
            RoleManager = roleManager;
            RoleRepository = roleRepository;
            UserManager = userManager;
        }

        public async Task<ListResultDto<IdentityRoleDto>> GetAllListAsync()
        {
            var list = await RoleRepository.GetListAsync();
            return new ListResultDto<IdentityRoleDto>(
                ObjectMapper.Map<List<IdentityRole>, List<IdentityRoleDto>>(list)
            );
        }

        public async Task<List<IdentityRoleDto>> GetAllListAsync2()
        {
            var list = await RoleRepository.GetListAsync();
            return new List<IdentityRoleDto>(
                ObjectMapper.Map<List<IdentityRole>, List<IdentityRoleDto>>(list)
            );
        }

        public async Task<IdentityRoleDto> GetAsync(Guid id)
        {
            return ObjectMapper.Map<IdentityRole, IdentityRoleDto>(
                await RoleManager.GetByIdAsync(id)
            );
        }

        //Get List Role with pagination
        public async Task<PagedResultDto<IdentityRoleDto>> GetListAsync(GetIdentityRolesInput input)
        {
            var list = await RoleRepository.GetListAsync(input.Sorting, input.MaxResultCount, input.SkipCount, input.Filter);
            var totalCount = await RoleRepository.GetCountAsync();

            return new PagedResultDto<IdentityRoleDto>(
                totalCount,
                ObjectMapper.Map<List<IdentityRole>, List<IdentityRoleDto>>(list));
        }

        //Update role
        public async Task<IdentityRoleDto> UpdateAsync(Guid id, IdentityRoleUpdateDto input)
        {

            var role = await RoleManager.GetByIdAsync(id);
            role.ConcurrencyStamp = input.ConcurrencyStamp;

            (await RoleManager.SetRoleNameAsync(role, input.Name)).CheckErrors();

            role.IsDefault = input.IsDefault;
            role.IsPublic = input.IsPublic;

            //input.MapExtraPropertiesTo(role);

            (await RoleManager.UpdateAsync(role)).CheckErrors();
            await CurrentUnitOfWork.SaveChangesAsync();

            return ObjectMapper.Map<IdentityRole, IdentityRoleDto>(role);
        }

        public async Task<bool> UpdateUserRole(Guid userId, string roleName)
        {
            var user = await UserManager.GetByIdAsync(userId);
            var roles = await UserManager.GetRolesAsync(user);
            foreach(var role in roles)
            {
               await UserManager.RemoveFromRoleAsync(user,role);
            }    
            await UserManager.AddToRoleAsync(user,roleName);
            return true;
        }

        public async Task<IdentityRoleDto> GetUserRole(Guid userId)
        {
            var user = await UserManager.GetByIdAsync(userId);
            var role = await UserManager.GetRolesAsync(user);
            if(role.Count>0)
            {
                var roleDto = new IdentityRoleDto
                {
                    Name = role.ToList().ElementAt(0)
                };
                return roleDto;
            }
            return null;
        }
        public Task<IdentityRoleDto> CreateAsync(IdentityRoleCreateDto input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
