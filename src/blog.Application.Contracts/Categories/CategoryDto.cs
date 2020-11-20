using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace blog.Categories
{
    //[AutoMapTo(typeof(Account))]
    public class CategoryDto : AuditedEntityDto<Guid>
    {
        [Required]
        public string Name { get; set; }
    }
}
