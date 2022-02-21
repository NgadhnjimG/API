using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YFE_API.Models.Entities;

namespace YFE_API.Services.Interfaces
{
    public interface IApplicantService
    {
        Task<IEnumerable<Applicant>> GetApplicants();
        Task<Applicant> GetApplicant(int id);
        Task<bool> PutApplicant(int id, Applicant applicant);
        Task<Applicant> PostApplicant(Applicant applicant);
        Task<Applicant> DeleteApplicant(int id);
    }
}
