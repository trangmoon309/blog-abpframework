using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace blog.Documents
{
    public class DocumentStore : AuditedAggregateRoot<Guid>
    {
        public string FileName { get; set; }
        public string Url { get; set; }
        public string TypeFile { get; set; }
        public int FileSize { get; set; }
    }
}
