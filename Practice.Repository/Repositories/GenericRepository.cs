using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Practice.Core.Repositories;

namespace Practice.Repository.Repositories
{
    public class GenericRepsitory<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext? _context;
        private readonly DbSet<TEntity>? _dbSet;

        public GenericRepsitory(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public Task AddAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}