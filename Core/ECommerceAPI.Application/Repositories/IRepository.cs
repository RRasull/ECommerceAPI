using ECommerceAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Application.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        public DbSet<TEntity> Table { get; }
    }
}
