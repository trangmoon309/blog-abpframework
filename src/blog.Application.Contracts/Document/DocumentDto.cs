using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace blog.Document
{
    public class DocumentDto : AuditedEntityDto<Guid>
    {
        public string FileName { get; set; }
        public string Url { get; set; }
        [Required]
        public string TypeFile { get; set; }
        public int FileSize { get; set; }
    }
}
