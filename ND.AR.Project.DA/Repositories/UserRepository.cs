using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ND.AR.Project.BL.Entities;
using ND.AR.Project.BL.Interface;
using ND.AR.Project.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.AR.Project.DA.Repositories
{
    public class UserRepository : Repository <User>,  IUserRepository

    {
        private readonly DatabaseContext _databaseContext;
        private readonly IMapper _mapper;

        public UserRepository(DatabaseContext databaseContext, IMapper _mapper) : base(databaseContext)
        {
            _databaseContext = databaseContext;
           
        }

        public  async Task<User> GetUserByEmail(string email)
        {
            return await Task.Run(() =>
            {
                return _databaseContext.Set<User>().Where(x => x.Email == email).FirstOrDefaultAsync();
            }); 
        }
    }
}
