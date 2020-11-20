using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace blog.Posts
{
    public class CreateUpdatePostDto : AuditedEntityDto<Guid>
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [StringLength(2000)]
        public string Content { get; set; }
        public string PhotoPath { get; set; }
        public IFormFile PhotoFile { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
    }
}
