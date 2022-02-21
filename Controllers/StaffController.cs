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
    public class StaffController : ControllerBase
    {
        private GeneralResponse<object> Response { get; set; }
        private readonly IStaffService _service;

        public StaffController(IStaffService service)
        {
            Response = new GeneralResponse<object>();
            _service = service;
        }

        // GET: api/Staff
        [HttpGet]
        public GeneralResponse<object> GetStaffs()
        {
            Response.ResponseData = this._service.GetStaffs();
            Response.Token = "";
            return Response ;
        }

        // GET: api/Staff/5
        [HttpGet("{id}")]
        public GeneralResponse<object> GetStaff(int id)
        {
            Response.ResponseData = this._service.GetStaff(id);
            Response.Token = "";
            return Response;
        }

        // PUT: api/Staff/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public GeneralResponse<object> PutStaff(int id, Staff staff)
        {
            Response.ResponseData = this._service.PutStaff(id,staff);
            Response.Token = "";
            return Response;
        }

        // POST: api/Staff
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public GeneralResponse<object> PostStaff(Staff staff)
        {
            Response.ResponseData = this._service.PostStaff(staff);
            Response.Token = "";
            return Response;
        }

        // DELETE: api/Staff/5
        [HttpDelete("{id}")]
        public GeneralResponse<object> DeleteStaff(int id)
        {
            Response.ResponseData = this._service.DeleteStaff(id);
            Response.Token = "";
            return Response;
        }
    }
}
