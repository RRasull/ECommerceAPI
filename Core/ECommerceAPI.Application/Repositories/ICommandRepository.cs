using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Application.Repositories
{
    public interface ICommandRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<bool> AddAsync(TEntity model);
        Task<bool> AddRangeAsync(List<TEntity> datas);
        bool Remove(TEntity model);
        bool RemoveRangeAll(List<TEntity> datas);
        Task<bool> RemoveByIdAsync(string id);
        bool Update(TEntity model);

        Task<int> SaveAsync();

    }
}
