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
    public class StaffService: IStaffService
    {
        private readonly YfeDbContext _context;

        public StaffService(YfeDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Staff>> GetStaffs()
        {
            return await _context.Staffs.ToListAsync();
        }
        public async Task<Staff> GetStaff(int id)
        {
            var staff = await _context.Staffs.FindAsync(id);


            return staff;
        }
        public async Task<bool> PutStaff(int id, Staff staff)
        {
            if (id != staff.Id)
            {
                return false;
            }

            _context.Entry(staff).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffExists(id))
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

        public async Task<Staff> PostStaff(Staff staff)
        {
            staff.Password= BCrypt.Net.BCrypt.HashPassword(staff.Password);
            var staffCreated = _context.Staffs.Add(staff);
            await _context.SaveChangesAsync();

            return staffCreated.Entity;
        }

        public async Task<Staff> DeleteStaff(int id)
        {
            var staff = await _context.Staffs.FindAsync(id);
          
            _context.Staffs.Remove(staff);
            await _context.SaveChangesAsync();

            return staff;
        }

        private bool StaffExists(int id)
        {
            return _context.Staffs.Any(e => e.Id == id);
        }
    }
}
