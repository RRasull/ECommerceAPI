using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repositories
{
    public interface IQueryRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> exp);
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> exp = null, params string[] includes);
        Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> exp = null);
        Task<TEntity> GetByIdAsync(string id);

    }
}
