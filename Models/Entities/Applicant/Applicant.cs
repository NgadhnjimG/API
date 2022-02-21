using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.Entities
{
    public class Applicant:  User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string ProfilePicPath { get; set; }
        public int? PhaseId { get; set; }
        [ForeignKey("PhaseId ")]
        public Phase Phase{ get; set; }
        public virtual ICollection<Document> Documents { get; set; }
    }
}
