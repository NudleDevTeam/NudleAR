using ND.AR.Project.BL.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.AR.Project.BL.Model.Request
{
    public class UserRequest
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public Role Role { get; set; }
   
        public string Password { get; set; }

    }
}
