using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YFE_API.Models.Entities
{
    public class Document : BaseClass
    {
        public int Id { get; set; }
        public string DocumentType { get; set; }
        public string Name { get; set; }
        public int? StaffUploadId { get; set; }
        [ForeignKey("StaffUploadId ")]
        public Staff Applicant { get; set; }
        public int? ApplicantUploadId { get; set; }
        [ForeignKey("ApplicantUploadId ")]
        public Applicant Staff { get; set; }
    }
}
