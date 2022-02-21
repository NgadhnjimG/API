using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.Entities
{
    public class StaffRoles
    {
        public int Id { get; set; }
        public int? StaffId{ get; set; }
        [ForeignKey("StaffId")]
        public Staff Staff{ get; set; }
        public int? RoleId { get; set; }
        [ForeignKey("RoleId")]
        public Role Role{ get; set; }
    }
}
