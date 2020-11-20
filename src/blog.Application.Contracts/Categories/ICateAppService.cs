using blog.Posts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace blog.Categories
{
    public interface ICateAppService: IApplicationService
    {
        Task<List<CategoryDto>> GetCateList();
        Task<bool> CreateCategory(CategoryDto createdCategory);
        Task<bool> UpdateCategory(CategoryDto updatedCategory);
        Task<bool> DeleteCategory(Guid categoryId);
        Task<List<PostDto>> GetPostInSameCategory(Guid categoryId);
        Task<string> GetCategoryName(Guid categoryId);
        Task<CategoryDto> GetSepecificCate(Guid categoryId);
    }
}
