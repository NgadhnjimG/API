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
    public class ApplicantsController : ControllerBase
    {
        private GeneralResponse<object> Response { get; set; }
        private readonly IApplicantService _service;

        public ApplicantsController(IApplicantService service)
        {
            Response = new GeneralResponse<object>();
            _service = service;
        }

        // GET: api/Applicants
        [HttpGet]
        public GeneralResponse<object> GetApplicants()
        {
            Response.ResponseData= _service.GetApplicants().Result;
            Response.Token = "";
            return Response;
        }

        // GET: api/Applicants/5
        [HttpGet("{id}")]
        public GeneralResponse<object> GetApplicant(int id)
        {
            Response.ResponseData = _service.GetApplicant(id).Result;
            Response.Token = "";
            
            return Response;
        }

        // PUT: api/Applicants/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<bool> PutApplicant(int id, Applicant applicant)
        {
            Response.ResponseData = _service.PutApplicant(id,applicant).Result;
            Response.Token = "";
            
            return Response.ResponseData!=null;
        }

        // POST: api/Applicants
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public GeneralResponse<object> PostApplicant(Applicant applicant)
        {

            Response.ResponseData = _service.PostApplicant(applicant).Result;
            Response.Token = "";

            return Response;
        }

        // DELETE: api/Applicants/5
        [HttpDelete("{id}")]
        public GeneralResponse<object> DeleteApplicant(int id)
        {
            Response.ResponseData = _service.DeleteApplicant(id).Result;
            Response.Token = "";
            
            return Response;
        }

    }
}
