using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.Entities
{
    public class Phase : BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Applicant> Applicants { get; set; }
    }
}
