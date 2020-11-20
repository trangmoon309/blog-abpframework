using System;
using System.Collections.Generic;
using System.Text;

namespace blog.Categories
{
    public class CreateUpdateCateResponse
    {
        public CategoryDto categoryDto { get; set; }
        public bool IsSuccess { get; set; }
        public string[] ErrorMesseage { get; set; }
        public string IdUser { get; set; }

    }
}
