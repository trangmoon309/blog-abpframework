using blog.Document;
using blog.Post;
using blog.Posts;
using blog.UriContracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace blog.Controllers
{
    [Route("api/post")]
    public class PostController : AbpController
    {
        protected IPostAppService postAppService { get; }
        protected IUriService uriService { get; }
        protected IDocumentAppService documentAppService { get; }

        public PostController(IPostAppService postAppService, IUriService uriService, IDocumentAppService documentAppService)
        {
            this.postAppService = postAppService;
            this.uriService = uriService;
            this.documentAppService = documentAppService;
        }

        [HttpGet]
        public async Task<List<PostDto>> GetListAsync()
        {
            return await postAppService.GetPosts();
        }

        [HttpGet]
        [Route("{postId}")]
        public async Task<PostDto> GetAsync(Guid postId)
        {
            return await postAppService.GetSepecificPost(postId);
        }

        [Authorize]
        [HttpGet]
        [Route("pagedPosts")]
        public async Task<PagedPostResponse> GetPagedAsync(PaginationQuery paginationQuery)
        {
            var paginationFilter = new PaginationFilter
            {
                PageNumber = paginationQuery.PageNumber,
                PageSize = paginationQuery.PageSize
            };

            var postsDto = await postAppService.GetPosts();

            if (paginationFilter == null || paginationFilter.PageNumber < 1 || paginationFilter.PageSize < 1)
            {
                return new PagedPostResponse(postsDto);
            }

            var postInCurrentPage = await postAppService.GetPagedPosts(paginationFilter.PageNumber, paginationFilter.PageSize);
            var paginationResponse = PaginationHeplers.CreatePaginationResponse(uriService, paginationFilter, postInCurrentPage);

            return paginationResponse;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        public async Task<CreateUpdatePostResponse> CreateAsync(CreateUpdatePostDto createdPost)
        {
            var uploadedfile = createdPost.PhotoFile;
            var documentDto = new DocumentDto
            {
                FileName = uploadedfile.FileName,
                TypeFile = uploadedfile.GetType().ToString(),
                Url = documentAppService.CreateDocumentUrl(uploadedfile)
            };
            var createdFile = await documentAppService.CreateAsync(documentDto);
            createdPost.PhotoPath = createdFile.Id.ToString();
            var result = await postAppService.CreatePost(createdPost);
            var response = new CreateUpdatePostResponse
            {
                postDto = null
            };
            if (result) response.IsSuccess = true;
            else
            {
                response.IsSuccess = false;
                response.Errors = new string[] { "Create post failed!" };
            }
            return response;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        [Route("{postId}")]
        public async Task<CreateUpdatePostResponse> UpdateAsync(CreateUpdatePostDto updatedPost, Guid postId)
        {
            updatedPost.Id = postId;
            var result = await postAppService.UpdatePost(updatedPost);
            var response = new CreateUpdatePostResponse();
            response.postDto = updatedPost;
            if (result) response.IsSuccess = true;
            else
            {
                response.IsSuccess = false;
                response.Errors = new string[] { "Update Fail!" };
            }
            return response;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete]
        [Route("{postid}")]
        public async Task<CreateUpdatePostResponse> DeleteAsync(Guid postid)
        {
            var result = await postAppService.DeletePost(postid);
            var response = new CreateUpdatePostResponse();
            if (result) response.IsSuccess = true;
            else
            {
                response.IsSuccess = false;
                response.Errors = new string[] { "Delete Fail!" };
            }
            return response;
        }


    }
}
