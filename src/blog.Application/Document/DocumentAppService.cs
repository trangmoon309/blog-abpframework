using blog.Documents;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace blog.Document
{
    public class DocumentAppService : ApplicationService, IDocumentAppService
    {
        private readonly IRepository<DocumentStore, Guid> _documentRepository;
        private readonly IWebHostEnvironment hostingEnvironment;

        public DocumentAppService(IRepository<DocumentStore, Guid> documentRepository, IWebHostEnvironment hostingEnvironment)
        {
            _documentRepository = documentRepository;
            this.hostingEnvironment = hostingEnvironment;
        }

        public async Task<DocumentDto> CreateAsync(DocumentDto createdDocument)
        {
            var document = ObjectMapper.Map<DocumentDto, DocumentStore>(createdDocument);
            var newdocument = await _documentRepository.InsertAsync(document);
            return ObjectMapper.Map<DocumentStore, DocumentDto>(newdocument);
        }

        public async Task<DocumentDto> GetAsync(Guid documentId)
        {
            var document = await _documentRepository.FirstOrDefaultAsync(x => x.Id.Equals(documentId));
            return ObjectMapper.Map<DocumentStore, DocumentDto>(document);
        }
        public string CreateDocumentUrl(IFormFile photoPath)
        {
            string uniqueFileName = String.Empty;
            uniqueFileName = Guid.NewGuid().ToString() + "_" + photoPath.FileName;
            var filePath = Path.Combine(hostingEnvironment.WebRootPath + "/imgs", uniqueFileName);
            // Use CopyTo() method provided by IFormFile interface to
            // copy the file to wwwroot/images folder
            photoPath.CopyTo(new FileStream(filePath, FileMode.Create));
            return uniqueFileName;
        }
    }
}
