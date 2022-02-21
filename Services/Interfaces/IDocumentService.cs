using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YFE_API.Models.Entities;

namespace YFE_API.Services.Interfaces
{
    public interface IDocumentService
    {
        Task<IEnumerable<Document>> GetDocuments();
        Task<Document> GetDocument(int id);
        Task<bool> PutDocument(int id, Document document);
        Task<Document> PostDocument(Document document);
        Task<Document> DeleteDocument(int id);
    }
}
