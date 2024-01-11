using ND.AR.Project.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.AR.Project.BL.Interfaces
{
    public  interface IUserService
    {
        Task<User> GetUserAsync(string email);
    }
}
