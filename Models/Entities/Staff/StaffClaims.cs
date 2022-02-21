using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.Entities
{
    public class StaffClaims
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        [ForeignKey("StaffId")]
        public Staff Staff { get; set; }
        public int? ClaimId { get; set; }
        [ForeignKey("ClaimId")]
        public Claim Claim { get; set; }
    }
}
