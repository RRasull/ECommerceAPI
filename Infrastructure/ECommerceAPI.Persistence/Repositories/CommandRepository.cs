using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities.Common;
using ECommerceAPI.Persistence.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories
{
    public class CommandRepository<TEntity> : ICommandRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ECommerceAppDbContext _context;

        public CommandRepository(ECommerceAppDbContext context)
        {
            _context = context;
        }

        public DbSet<TEntity> Table => _context.Set<TEntity>();

        public async Task<bool> AddAsync(TEntity model)
        {
            EntityEntry entityEntry = await Table.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }


        public async Task<bool> AddRangeAsync(List<TEntity> datas)
        {
            await Table.AddRangeAsync(datas);
            return true;
        }

        public bool Remove(TEntity model)
        {
            EntityEntry<TEntity> entityEntry = Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool RemoveRangeAll(List<TEntity> datas)
        {
            Table.RemoveRange(datas);
            return true;
        }

        public async Task<bool> RemoveByIdAsync(string id)
        {
            TEntity model = await Table.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
            //EntityEntry<TEntity> entityEntry = Table.Remove(model);
            //return entityEntry.State == EntityState.Deleted;

            return Remove(model);
        }

        public bool Update(TEntity model)
        {
            EntityEntry<TEntity> entityEntry = _context.Update(model);
           return entityEntry.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync()
            => await _context.SaveChangesAsync();


    }
}
