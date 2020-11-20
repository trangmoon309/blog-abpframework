using blog.Document;
using blog.Permissions;
using blog.Posts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace blog.Post
{
    public class PostService : ApplicationService, IPostAppService
    {
        private readonly IRepository<blog.Posts.Post, Guid> _postRepository;
        protected IDocumentAppService documentAppService { get; }

        public PostService(IRepository<Posts.Post, Guid> postRepository, IDocumentAppService documentAppService)
        {
            _postRepository = postRepository;
            this.documentAppService = documentAppService;
        }

        public async Task<int> CountPosts()
        {
            return await _postRepository.CountAsync();
        }

        public async Task<bool> CreatePost(CreateUpdatePostDto createdPost)
        {
            var isExistedTitlePost = await IsTitleExisted(createdPost.Title);
            if (isExistedTitlePost) return false;
            createdPost.CreatedAt = DateTime.Now;
            createdPost.CreationTime = DateTime.Now;
            await _postRepository.InsertAsync(ObjectMapper.Map<CreateUpdatePostDto,blog.Posts.Post>(createdPost));
            return true;
        }

        public async Task<bool> DeletePost(Guid postId)
        {
            var isExistedPost = await IsExistedPost(postId);
            if (!isExistedPost) return false;
            var deletedPost = await _postRepository.FirstAsync(x => x.Id == postId);
            await _postRepository.DeleteAsync(deletedPost);
            return true;
        }

        public async Task<List<PostDto>> GetPosts()
        {
            var listPosts = await _postRepository.ToListAsync();
            var listPostDto = ObjectMapper.Map<List<blog.Posts.Post>, List<PostDto>> (listPosts);
            return listPostDto;
        }

        public async Task<PostDto> GetSepecificPost(Guid postId)
        {
            var post = await _postRepository.FirstOrDefaultAsync(x => String.Equals(x.Id, postId) == true);
            return ObjectMapper.Map<blog.Posts.Post, PostDto>(post);
        }

        public async Task<bool> UpdatePost(CreateUpdatePostDto updatedPostDto)
        {
            var isExistedId = await IsExistedPost(updatedPostDto.Id);
            if (!isExistedId) return false;
            var post = await _postRepository.FirstOrDefaultAsync(x => x.Id == updatedPostDto.Id);
            //dùng mapper bị lỗi
            post.Title = updatedPostDto.Title;
            post.Author = updatedPostDto.Author;
            post.CategoryId = updatedPostDto.CategoryId;
            post.Description = updatedPostDto.Description;
            post.CreatedAt = updatedPostDto.CreatedAt;
            post.CreationTime = updatedPostDto.CreationTime;
            post.PhotoPath = updatedPostDto.PhotoPath;
            post.Content = updatedPostDto.Content;

            await _postRepository.UpdateAsync(post);
            return true;
        }

        public async Task<bool> IsTitleExisted(string postTitle)
        {
            var existedPost = await  _postRepository.FirstOrDefaultAsync(x => x.Title.Equals(postTitle));
            return (existedPost != null);
        }

        public async Task<bool> IsExistedPost(Guid postId)
        {
            var existedPost = await _postRepository.AnyAsync(x => x.Id == postId);
            return (existedPost);
        }

        public async Task<CreateUpdatePostDto> GetUpdatedPost(Guid postId)
        {
            var isExistedPost = await IsExistedPost(postId);
             if (!isExistedPost) return null;
            var postDto = await GetSepecificPost(postId);
            var updatedPost = ObjectMapper.Map<PostDto, CreateUpdatePostDto>(postDto);
            return updatedPost;
        }

        public async Task<List<PostDto>> GetPagedPosts(int pageNum, int pageSize)
        {
            var skip = (pageNum - 1) * pageSize;// ví dụ muốn xem trang 2 => skip = 1*pagesize, nghĩa là skip trang 1
            var posts = await _postRepository.Skip(skip).Take(pageSize).ToListAsync();
            return ObjectMapper.Map<List<blog.Posts.Post>, List<PostDto>>(posts);
        }
    }
}
