using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.Entities
{
    public class BaseClass
    {
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
