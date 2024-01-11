﻿using ND.AR.Project.BL.Entities;
using ND.AR.Project.BL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.AR.Project.BL.Interfaces
{
    public  interface IUserRepository : IRepository <User>
    {
        Task<User> GetUserByEmail(string email);
    }
}
