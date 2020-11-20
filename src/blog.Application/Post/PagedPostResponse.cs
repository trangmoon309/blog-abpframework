using blog.Posts;
using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Post
{
    public class PagedPostResponse
    {
        public IEnumerable<PostDto> postDtos { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        public string NextPage { get; set; }
        public string PreviousPage { get; set; }
        public PagedPostResponse() { }
        public PagedPostResponse(IEnumerable<PostDto> data)
        {
            postDtos = data;
        }
    }
}
