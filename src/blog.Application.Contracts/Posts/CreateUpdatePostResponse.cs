using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Posts
{
    public class CreateUpdatePostResponse
    {
        public CreateUpdatePostDto postDto { get; set; }
        public bool IsSuccess { get; set; }
        public string[] Errors { get; set; }
    }
}
