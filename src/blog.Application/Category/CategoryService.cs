using Abp.Authorization;
using AutoMapper;
using blog.Categories;
using blog.Identity;
using blog.Permissions;
using blog.Posts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;
using Volo.Abp.Users;

namespace blog.Category
{
    public class CategoryService : ApplicationService, ICateAppService
    {
        private readonly IRepository<blog.Categories.Category, Guid> _cateRepository;
        private readonly IRepository<blog.Posts.Post, Guid> _postRepository;
        private readonly IAuthorizationService authorization;
        private readonly ICurrentUser _currentUser;

        public CategoryService(IRepository<Categories.Category, Guid> cateRepository, IRepository<Posts.Post, Guid> postRepository, IAuthorizationService authorizationService, ICurrentUser currentUser)
        {
            _cateRepository = cateRepository;
            _postRepository = postRepository;
            authorization = authorizationService;
            _currentUser = currentUser;
        }

        public async Task<bool> CreateCategory(CategoryDto createdCategory)
        {
            var result = await authorization.IsGrantedAsync(blogPermissions.Category.CreateCategory);
            if (result)
            {
                var isExistedName = await IsExistedCategory(createdCategory);
                if (isExistedName) return false;
                createdCategory.CreationTime = DateTime.Now;
                createdCategory.CreatorId = CurrentUser.Id;
                var addedCate = ObjectMapper.Map<CategoryDto, blog.Categories.Category>(createdCategory);
                await _cateRepository.InsertAsync(addedCate);
                return true;
            }
            else return false;
        }

        public async Task<bool> DeleteCategory(Guid categoryId)
        {
            var isExistedId = await IsExistedCategoryId(categoryId);
            if (!isExistedId) return false;

            var deletedCategory = await _cateRepository.FirstOrDefaultAsync(x => x.Id == categoryId);
            await _cateRepository.DeleteAsync(deletedCategory);
            return true;
        }

        public async Task<string> GetCategoryName(Guid categoryId)
        {
            var isExistedId = await IsExistedCategoryId(categoryId);
            if (!isExistedId) return null;
            var cate = await _cateRepository.FirstOrDefaultAsync(x => x.Id == categoryId);
            return cate.Name;
        }
        public async Task<CategoryDto> GetSepecificCate(Guid categoryId)
        {
            var isExistedId = await IsExistedCategoryId(categoryId);
            if (!isExistedId) return null;
            var cate = await _cateRepository.FirstOrDefaultAsync(x => x.Id == categoryId);
            return ObjectMapper.Map<blog.Categories.Category, CategoryDto>(cate);
        }


        public async Task<List<CategoryDto>> GetCateList()
        {
            var listCate = await _cateRepository.ToListAsync();
            var listCateDTO = ObjectMapper.Map<List<blog.Categories.Category>, List<blog.Categories.CategoryDto>>(listCate);
            return listCateDTO;
        }

        public async Task<List<PostDto>> GetPostInSameCategory(Guid categoryId)
        {
            var isExistedId = await IsExistedCategoryId(categoryId);
            if (!isExistedId) return null;

            var listOfPost = _postRepository.Where(x => x.CategoryId == categoryId).Select(x => x).ToList();
            var listOfPostDto = ObjectMapper.Map<List<blog.Posts.Post>, List<PostDto>>(listOfPost);
            return listOfPostDto;
        }

        public async Task<bool> UpdateCategory(CategoryDto updatedCategory)
        {
            var isExistedId = await IsExistedCategoryId(updatedCategory.Id);
            if (!isExistedId) return false;
            var cate = await _cateRepository.FirstOrDefaultAsync(x => x.Id == updatedCategory.Id);
            cate.Name = updatedCategory.Name;
            await _cateRepository.UpdateAsync(cate);
            return true;
        }

        public async Task<bool> IsExistedCategory(CategoryDto categoryDto)
        {
            var isExistedName = await _cateRepository.FirstOrDefaultAsync(x => x.Name == categoryDto.Name);
            var isExistedCate = await _cateRepository.FirstOrDefaultAsync(x => x.Id == categoryDto.Id);

            return (isExistedCate !=null || isExistedName !=null);
        }

        public async Task<bool> IsExistedCategoryId(Guid id)
        {
            var isExistedCate = await _cateRepository.FirstOrDefaultAsync(x => x.Id == id);

            return (isExistedCate != null);
        }
    }
}
