using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YFE_API.Configuration;
using YFE_API.Models.DTOs.Responses;
using YFE_API.Models.Entities;
using YFE_API.Services.Interfaces;

namespace YFE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        private GeneralResponse<object> Response { get; set; }
        private readonly IDocumentService _service;

        public DocumentsController(IDocumentService service)
        {
            Response = new GeneralResponse<object>();
            _service = service;
        }

        // GET: api/Documents
        [HttpGet]
        public GeneralResponse<object> GetDocuments()
        {
            Response.ResponseData = _service.GetDocuments().Result;
            Response.Token = "";
            return Response;
        }

        // GET: api/Documents/5
        [HttpGet("{id}")]
        public GeneralResponse<object> GetDocument(int id)
        {
            Response.ResponseData = _service.GetDocument(id).Result;
            Response.Token = "";
            return Response;
        }

        // PUT: api/Documents/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public GeneralResponse<object> PutDocument(int id, Document document)
        {
            Response.ResponseData = _service.PutDocument(id, document).Result;
            Response.Token = "";
            return Response;
        }

        // POST: api/Documents
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public GeneralResponse<object> PostDocument(Document document)
        {
            Response.ResponseData = _service.PostDocument(document).Result;
            Response.Token = "";
            return Response;
        }

        // DELETE: api/Documents/5
        [HttpDelete("{id}")]
        public GeneralResponse<object> DeleteDocument(int id)
        {
            Response.ResponseData = _service.DeleteDocument(id).Result;
            Response.Token = "";
            return Response;
        }

    }
}
