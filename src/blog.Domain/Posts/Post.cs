using blog.Categories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace blog.Posts
{
    public class Post : AuditedAggregateRoot<Guid>
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string Description { get; set; }
        [Required]
        public string Content { get; set; }
        public string PhotoPath { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("Category")]
        [Required]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Post()
        {

        }
        public Post(Guid Id, string title, string author, string des, string content, string photopath, DateTime createdTime, Guid cateId) : base(Id)
        {
            Title = title;
            Author = author;
            Description = des;
            Content = content;
            PhotoPath = photopath;
            CreatedAt = createdTime;
            CategoryId = cateId;
        }
    }

}
