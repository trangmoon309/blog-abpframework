using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.Posts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Web.Pages.Post
{
    public class PostListModel : PageModel
    {
        private readonly IPostAppService postService;

        public PostListModel(IPostAppService postService)
        {
            this.postService = postService;
        }

        public List<PostDto> PostList { get; set; } = new List<PostDto>();

        public async Task<IActionResult> OnGetAsync()
        {
            PostList = await postService.GetPosts();
            return Page();
        }
    }
}