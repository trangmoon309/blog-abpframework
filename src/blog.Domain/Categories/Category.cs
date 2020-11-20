using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace blog.Categories
{
    public class Category : Entity<Guid>
    {
        public string Name { get; set; }
        public Category(Guid id, string name) : base(id)
        {
            Name = name;
        }
    }
}
