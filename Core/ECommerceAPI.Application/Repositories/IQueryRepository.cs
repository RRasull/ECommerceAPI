using ECommerceAPI.Domain.Entities.Common;
using System.Linq.Expressions;

namespace ECommerceAPI.Application.Repositories
{
    public interface IQueryRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll(bool tracking = true);
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> exp, bool tracking = true);
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> exp = null, bool tracking = true);
        Task<bool> IsExistsAsync(Expression<Func<TEntity, bool>> exp = null, bool tracking = true);
        Task<TEntity> GetByIdAsync(string id, bool tracking = true);

    }
}
