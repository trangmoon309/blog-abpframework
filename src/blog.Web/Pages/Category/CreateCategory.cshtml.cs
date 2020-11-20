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
    public class CreateCategoryModel : PageModel
    {
        private readonly ICateAppService categoryService;
        private readonly IAuthorizationService authorization;

        public CreateCategoryModel(ICateAppService categoryService, IAuthorizationService authorization)
        {
            this.categoryService = categoryService;
            this.authorization = authorization;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public CategoryDto CreateCategoryInput { get; set; }

        public bool flag { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var result = await authorization.IsGrantedAsync(blogPermissions.Category.CreateCategory);
            if(result)
            {
                flag = await categoryService.CreateCategory(CreateCategoryInput);
                return Page();
            }
            return RedirectToPage("/Error/AccessDenied", new { errorMesseage = "You don't have permission of Create Category!" });
        }
    }
}