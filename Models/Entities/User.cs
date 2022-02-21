using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.Entities
{
    public class User: BaseClass
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
