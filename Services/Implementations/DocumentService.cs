using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YFE_API.Configuration;
using YFE_API.Models.Entities;
using YFE_API.Services.Interfaces;

namespace YFE_API.Services.Implementations
{
    public class DocumentService: IDocumentService
    {
        private readonly YfeDbContext _context;

        public DocumentService(YfeDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Document>> GetDocuments()
        {
            return await _context.Documents.ToListAsync();
        }

        public async Task<Document> GetDocument(int id)
        {
            var document = await _context.Documents.FindAsync(id);

            return document;
        }

        public async Task<bool> PutDocument(int id, Document document)
        {
            if (id != document.Id)
            {
                return false;
            }

            _context.Entry(document).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

            return true;
        }

        public async Task<Document> PostDocument(Document document)
        {
            var doc=_context.Documents.Add(document);
            await _context.SaveChangesAsync();

            return doc.Entity;
        }

        public async Task<Document> DeleteDocument(int id)
        {
            var document = await _context.Documents.FindAsync(id);
            

            _context.Documents.Remove(document);
            await _context.SaveChangesAsync();

            return document;
        }

        private bool DocumentExists(int id)
        {
            return _context.Documents.Any(e => e.Id == id);
        }
    }
}
