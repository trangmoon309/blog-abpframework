using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace blog.Document
{
    public interface IDocumentAppService
    {
        Task<DocumentDto> CreateAsync(DocumentDto createdDocument);
        Task<DocumentDto> GetAsync(Guid documentId);
        string CreateDocumentUrl(IFormFile photoPath);
    }
}
