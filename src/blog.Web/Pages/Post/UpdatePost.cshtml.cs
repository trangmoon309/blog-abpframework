using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using blog.Categories;
using blog.Permissions;
using blog.Posts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Web.Pages.Post
{
    public class UpdatePostModel : PageModel
    {
        private readonly IPostAppService postService;
        private readonly ICateAppService cateService;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IAuthorizationService authorization;


        public UpdatePostModel(IPostAppService postService, ICateAppService cateService, IHostingEnvironment hostingEnvironment, IAuthorizationService authorization)
        {
            this.postService = postService;
            this.cateService = cateService;
            this.hostingEnvironment = hostingEnvironment;
            this.authorization = authorization;
        }

        [BindProperty(SupportsGet = true)]
        public CreateUpdatePostDto UpdatedPostDto { get; set; } = new CreateUpdatePostDto();

        public List<CategoryDto> CategoryList { get; set; }


        public async Task<IActionResult> OnGetAsync(Guid postId)
        {
            var result = await authorization.IsGrantedAsync(blogPermissions.Post.UpdatePost);
            if(result)
            {
                CategoryList = await cateService.GetCateList();
                UpdatedPostDto = await postService.GetUpdatedPost(postId);
                return Page();
            }
            else
            {
                return RedirectToPage("/Error/AccessDenied", new { errorMesseage = "You don't have permission of Update Post!" });
            }

        }

        public bool flag { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (UpdatedPostDto.PhotoFile != null)
                {
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + UpdatedPostDto.PhotoFile.FileName;
                    var filePath = Path.Combine(hostingEnvironment.WebRootPath + "/imgs", uniqueFileName);

                    UpdatedPostDto.PhotoFile.CopyTo(new FileStream(filePath, FileMode.Create));
                    UpdatedPostDto.PhotoPath = uniqueFileName;
                }
                      
                flag = await postService.UpdatePost(UpdatedPostDto);
            }
            return RedirectToPage("/Post/PostList");
        }

        public async Task<IActionResult> OnPostDeletePostAsync()
        {
            var flag = await postService.DeletePost(UpdatedPostDto.Id);
            return RedirectToPage("/Post/PostList");
        }
    }
}