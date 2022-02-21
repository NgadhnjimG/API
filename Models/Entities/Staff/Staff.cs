using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.Entities
{
    public class Staff : User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string ProfilePicPath { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<StaffClaims> StaffClaims { get; set; }
        public virtual ICollection<StaffRoles> StaffRoles { get; set; }

    }
}
