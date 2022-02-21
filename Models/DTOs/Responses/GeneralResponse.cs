using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.DTOs.Responses
{
    public class GeneralResponse<T>
    {
        public T ResponseData { get; set; }
        public string Token { get; set; }
    }
}
