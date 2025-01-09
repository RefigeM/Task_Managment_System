using TaskManagmentSystem.Core.Entities.Common;

namespace TaskManagmentSystem.Core.Repositories;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
	IQueryable<T> GetAll();
	Task<T?> GetByIdAsync(int id);
	IQueryable<T> GetWhere(Func<T, bool> expression);
	Task<bool> IsExistAsync(int id);
	Task AddAsync(T entity);
	void Delete(T entity);
	Task<int> SaveAsync();
}
