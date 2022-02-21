using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YFE_API.Configuration;
using YFE_API.Models.DTOs.Recievers;
using YFE_API.Models.Entities;
using YFE_API.Services.Interfaces;

namespace YFE_API.Services.Implementations
{
    public class UserService : IUserInterface
    {
        private readonly YfeDbContext _context;

        public UserService(YfeDbContext context)
        {
            _context = context;
        }
        public bool Login(User userReciever)
        {
            //staff check
            var staff = this._context.Staffs.Where(x => x.Email == userReciever.Email).FirstOrDefault();
            bool validStaff=false;
            if (staff != null)
            {
                validStaff = BCrypt.Net.BCrypt.Verify(userReciever.Password, staff.Password);
            }

            //applicant check
            var applicant = this._context.Applicants.Where(x => x.Email == userReciever.Email).FirstOrDefault();
            bool validApplicant=false;
            if (applicant != null)
            {
                validApplicant = BCrypt.Net.BCrypt.Verify(userReciever.Password, applicant.Password);
            }

            if (staff != null) return validStaff;
            else if (applicant != null) return validApplicant;
            else
                return false;
        }
    }
}
