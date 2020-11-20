using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Categories;
using blog.Posts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Web.Pages.Post
{
    public class PostDetailModel : PageModel
    {
        private readonly IPostAppService postService;
        private readonly ICateAppService cateService;


        public PostDetailModel(IPostAppService postService, ICateAppService cateService)
        {
            this.postService = postService;
            this.cateService = cateService;
        }

        [BindProperty]
        public Guid PostDetailInput { get; set; }

        public List<PostDto> PostList { get; set; } = new List<PostDto>();
        public PostDto SpecificPost { get; set; }

        public string CategoryName { get; set; }
        public async Task<IActionResult> OnGetAsync(Guid postId)
        {
            PostList = await postService.GetPosts();
            SpecificPost = await postService.GetSepecificPost(postId);
            CategoryName = await cateService.GetCategoryName(SpecificPost.CategoryId);
            return Page();
        }
    }
}