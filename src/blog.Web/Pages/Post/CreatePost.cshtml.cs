using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using blog.Categories;
using blog.Permissions;
using blog.Posts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace blog.Web.Pages.Post
{
    public class CreatePostModel : PageModel
    {
        private readonly IPostAppService postService;
        private readonly ICateAppService cateAppService;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IAuthorizationService authorization;

        public CreatePostModel(IPostAppService postService, ICateAppService cateAppService, IHostingEnvironment hostingEnvironment, IAuthorizationService authorization)
        {
            this.postService = postService;
            this.cateAppService = cateAppService;
            this.hostingEnvironment = hostingEnvironment;
            this.authorization = authorization;
        }

        public async Task<IActionResult> OnGet()
        {
            var result = await authorization.IsGrantedAsync(blogPermissions.Post.CreatePost);
            if(result)
            {
                ListCategory = await cateAppService.GetCateList();
                return Page();
            }
            return RedirectToPage("/Error/AccessDenied", new { errorMesseage = "You don't have permission of Create Post!" });
        }

        [BindProperty]
        public CreateUpdatePostDto postDto { get; set; }

        public List<CategoryDto> ListCategory { get; set; }
        public bool flag { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (postDto.PhotoFile != null)
                {
                    postDto.PhotoPath = CreatePhoto(postDto.PhotoFile);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Please choose a photo represent for this post.");
                }
                flag = await postService.CreatePost(postDto);
            }
            return await this.OnGet();
        }


        public string CreatePhoto(IFormFile photoPath)
        {
            string uniqueFileName = null;
            uniqueFileName = Guid.NewGuid().ToString() + "_" + photoPath.FileName;
            var filePath = Path.Combine(hostingEnvironment.WebRootPath + "/imgs", uniqueFileName);
            // Use CopyTo() method provided by IFormFile interface to
            // copy the file to wwwroot/images folder
            postDto.PhotoFile.CopyTo(new FileStream(filePath, FileMode.Create));
            return uniqueFileName;
        }
    }
}