using ND.AR.Project.BL.Interface;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ND.AR.Project.Shared;

namespace ND.AR.Project.DA.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DatabaseContext _databaseContext;

        public Repository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _databaseContext.Set<TEntity>().FindAsync(entity);
            await _databaseContext.SaveChangesAsync();
        }
    }
}
