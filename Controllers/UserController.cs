using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YFE_API.Models.DTOs.Responses;
using YFE_API.Models.Entities;
using YFE_API.Services.Interfaces;

namespace YFE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserInterface _service;
        private GeneralResponse<object> Res;

        public UserController(IUserInterface service)
        {
            this._service = service;
            this.Res = new GeneralResponse<object>();
        }

        [HttpGet]
        public User Get()
        {
            User u1 = new User();
            u1.Email = "filan@gmail.com";
            u1.Username = "filan";
            u1.Password = "123456";
            return u1;
        }

        [HttpPost("authenticate/rest")]
        public GeneralResponse<object> PostREST(User user)
        {
            Res.ResponseData = this._service.Login(user);
            Res.Token = "";
            return Res;
        }

        [HttpPost("authenticate/soap")]
        public GeneralResponse<object> PostXML(User User)
        {
            Res.ResponseData = this._service.Login(User);
            Res.Token = "";
            return Res;
        }
    }
}
