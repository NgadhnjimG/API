using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YFE_API.Models.Entities;

namespace YFE_API.Services.Interfaces
{
    public interface IStaffService
    {
        Task<IEnumerable<Staff>> GetStaffs();
        Task<Staff> GetStaff(int id);
        Task<bool> PutStaff(int id, Staff staff);
        Task<Staff> PostStaff(Staff staff);
        Task<Staff> DeleteStaff(int id);
    }
}
