using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YFE_API.Models.DTOs.Recievers;

namespace YFE_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntryController : ControllerBase
    {
        //private readonly 
        public EntryController() 
        {
            
        }
        [HttpPost("/authenticate")]
        public void Authenticate(UserReciever userReciever) 
        {

            
        }
    }
}
