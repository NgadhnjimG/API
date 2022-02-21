using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YFE_API.Configuration;
using YFE_API.Models.Entities;
using YFE_API.Services.Interfaces;

namespace YFE_API.Services.Implementations
{
    public class ApplicantService: IApplicantService
    {

        private readonly YfeDbContext _context;

        public ApplicantService(YfeDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Applicant>> GetApplicants()
        {
            return await _context.Applicants.ToListAsync();
        }

        public async Task<Applicant> GetApplicant(int id)
        {
            var applicant = await _context.Applicants.FindAsync(id);

            //if (applicant == null)
            //{
            //    return NotFound();
            //}

            return applicant;
        }

        public async Task<bool> PutApplicant(int id, Applicant applicant)
        {
            if (id != applicant.Id)
            {
                return false;
            }

            _context.Entry(applicant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicantExists(id))
                {
                    return false;
                }
                else
                {
                    throw;
                }
            }

            return true;
        }

        // POST: api/Applicants
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
       
        public async Task<Applicant> PostApplicant(Applicant applicant)
        {
            applicant.Password = BCrypt.Net.BCrypt.HashPassword(applicant.Password);
            var applicantCreated=_context.Applicants.Add(applicant);
            await _context.SaveChangesAsync();

            return applicantCreated.Entity;
        }

        public async Task<Applicant> DeleteApplicant(int id)
        {
            var applicant = await _context.Applicants.FindAsync(id);
            //if (applicant == null)
            //{
            //    return NotFound();
            //}

            _context.Applicants.Remove(applicant);
            await _context.SaveChangesAsync();

            return applicant;
        }

        private bool ApplicantExists(int id)
        {
            return _context.Applicants.Any(e => e.Id == id);
        }
    }
}
