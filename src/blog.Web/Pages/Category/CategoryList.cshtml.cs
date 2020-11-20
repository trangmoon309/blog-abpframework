using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Categories;
using blog.Category;
using blog.Posts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Web.Pages.Category
{
    public class CategoryListModel : PageModel
    {
        private readonly ICateAppService categoryService;

        public CategoryListModel(ICateAppService categoryService)
        {
            this.categoryService = categoryService;
        }

        //[BindProperty(SupportsGet = true)]
        public List<CategoryDto> CategoryList { get; set; } = new List<CategoryDto>();

        public List<PostDto> SamePostList { get; set; } = new List<PostDto>();
        
        public async Task<IActionResult> OnGetAsync()
        {
            CategoryList = await categoryService.GetCateList();
            return Page();
        }

    }
}