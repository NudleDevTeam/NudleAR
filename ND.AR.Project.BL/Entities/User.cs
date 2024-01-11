using ND.AR.Project.BL.Enum;
using ND.AR.Project.Shared;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.AR.Project.BL.Entities
{
    public  class User : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
        public string PasswordHash { get; set; }

    }
}
