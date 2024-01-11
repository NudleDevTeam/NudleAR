using ND.AR.Project.BL.Entities;
using ND.AR.Project.BL.Interfaces;
using NuGet.Protocol.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.AR.Project.DA.Services
{
   
    public class UserService : IUserRepository
    {
        public readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public  async Task<User> GetUserByEmail(string email)
        {
          return  await _userRepository.GetUserByEmail(email);
        }
    }
}
