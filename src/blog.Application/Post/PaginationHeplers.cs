using blog.Posts;
using blog.UriContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace blog.Post
{
    public static class PaginationHeplers
    {
        public static PagedPostResponse CreatePaginationResponse(IUriService uriService, PaginationFilter filter, List<PostDto> posts)
        {
            //lấy uri để query lấy post ở next page
            var nextPage = filter.PageNumber >= 1 ? uriService
                .GetAllPostsUri(new PaginationQuery(filter.PageNumber + 1, filter.PageSize)).ToString() : null;

            //lấy uri để query lấy post ở previous page
            var previousPage = filter.PageNumber - 1 >= 1 ? uriService
                .GetAllPostsUri(new PaginationQuery(filter.PageNumber - 1, filter.PageSize)).ToString() : null;

            return new PagedPostResponse
            {
                postDtos = posts,
                NextPage = posts.Any() ? nextPage : null,
                PreviousPage = previousPage,
                PageNumber = filter.PageNumber >= 1 ? filter.PageNumber : (int?)null,
                PageSize = filter.PageSize >= 1 ? filter.PageSize : (int?)null
            };
        }
    }
}
