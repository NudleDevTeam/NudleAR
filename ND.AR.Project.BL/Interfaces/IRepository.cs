using ND.AR.Project.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.AR.Project.BL.Interface
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
    }
}
