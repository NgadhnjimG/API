using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YFE_API.Models.DTOs.Recievers;
using YFE_API.Models.Entities;

namespace YFE_API.Services.Interfaces
{
    public interface IUserInterface
    {
        bool Login(User userReciever);
    }
}
