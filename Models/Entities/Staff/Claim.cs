using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.Entities
{
    public class Claim : BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<StaffClaims> StaffClaims { get; set; }
    }
}
