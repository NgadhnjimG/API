using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.Entities
{
    public class Role : BaseClass
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public virtual ICollection<StaffRoles> StaffRoles { get; set; }

    }
}
