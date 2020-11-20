using System;
using blog.UriContracts;
using Microsoft.AspNetCore.WebUtilities;

namespace blog.UriServices
{
    public class UriService : IUriService
    {
        private readonly string baseUri;

        public UriService(string baseUri)
        {
            this.baseUri = baseUri;
        }

        public Uri GetAllPostsUri(PaginationQuery pagination = null)
        {
            var uri = new System.Uri(baseUri);
            if (pagination == null)
            {
                return uri;
            }
            var modifiedUri = QueryHelpers.AddQueryString(baseUri + "api/post/", "pageNumber", pagination.PageNumber.ToString());
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageSize", pagination.PageSize.ToString());
            //https://localhost:44333/?pageNumber=2&pageSize=3
            return new System.Uri(modifiedUri);
        }

        public Uri GetPostUri(string postId)
        {
            return new System.Uri(baseUri + ("api/post/").Replace("{postId}", postId));
        }
    }
}
