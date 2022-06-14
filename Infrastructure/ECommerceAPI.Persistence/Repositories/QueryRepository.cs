using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities.Common;
using ECommerceAPI.Persistence.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories
{
    public class QueryRepository<TEntity> : IQueryRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ECommerceAppDbContext _context;

        public QueryRepository(ECommerceAppDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public IQueryable<TEntity> GetAll()
            => Table.AsQueryable();



        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> exp = null)
            => await Table.FirstOrDefaultAsync(exp);

        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> exp)
            => Table.Where(exp);

        public async Task<TEntity> GetByIdAsync(string id)
            => await Table.FirstOrDefaultAsync(p => p.Id == Guid.Parse(id));

        public async Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> exp = null)
            => await _context.Set<TEntity>().AnyAsync(exp);
    }
}
