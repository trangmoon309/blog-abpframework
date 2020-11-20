using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Categories;
using blog.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Web.Pages.Category
{
    public class UpdateCategoryModel : PageModel
    {
        private readonly ICateAppService categoryService;
        private readonly IAuthorizationService authorization;

        public UpdateCategoryModel(ICateAppService categoryService, IAuthorizationService authorization)
        {
            this.categoryService = categoryService;
            this.authorization = authorization;
        }

        [BindProperty(SupportsGet = true)]
        public CategoryDto SpecificCategoryDto { get; set; } = new CategoryDto();

        public async Task<IActionResult> OnGetAsync(Guid cateId)
        {
            var result = await authorization.IsGrantedAsync(blogPermissions.Category.CreateCategory);
            if(result)
            {
                SpecificCategoryDto.Name = await categoryService.GetCategoryName(cateId);
                SpecificCategoryDto.Id = cateId;

                return Page();
            }    

            else
            {
                return RedirectToPage("/Error/AccessDenied", new { errorMesseage = "You don't have permission of Update Category!" } );
            }                
            
        }

        public bool flag { get; set; }

        public async Task<IActionResult> OnPostUpdateCategoryAsync()
        {
            flag = await categoryService.UpdateCategory(SpecificCategoryDto);
            return await this.OnGetAsync(SpecificCategoryDto.Id);
        }

        public async Task<IActionResult> OnPostDeleteCategoryAsync()
        {
            flag = await categoryService.DeleteCategory(SpecificCategoryDto.Id);
            return RedirectToPage("/Category/CategoryList");
        }
    }
}