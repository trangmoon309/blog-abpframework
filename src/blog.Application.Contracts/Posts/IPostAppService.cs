using blog.Document;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace blog.Posts
{
    public interface IPostAppService : IApplicationService
    {
        Task<bool> CreatePost(CreateUpdatePostDto createdPost);
        Task<List<PostDto>> GetPosts();
        Task<PostDto> GetSepecificPost(Guid postId);
        Task<CreateUpdatePostDto> GetUpdatedPost(Guid postId);
        Task<bool> UpdatePost(CreateUpdatePostDto updatedPostDto);
        Task<bool> DeletePost(Guid postId);
        //List<PostDto> GetPagingPosts(PaginationFilter paginationFilter);
        Task<int> CountPosts();
        Task<List<PostDto>> GetPagedPosts(int pageNum, int pageSize);
    }
}
