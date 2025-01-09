using Microsoft.EntityFrameworkCore;
using TaskManagmentSystem.Core.Entities.Common;
using TaskManagmentSystem.Core.Repositories;
using TaskManagmentSystem.DAL.Context;

namespace TaskManagmentSystem.DAL.Repositories;

public class GenericRepository<T>(ManagmentDbContext _context) :IGenericRepository<T> where T :BaseEntity, new()	
{

	protected DbSet<T> Table = _context.Set<T>();
	public async Task AddAsync(T entity)
	{
		await Table.AddAsync(entity);
	}

	public void Delete(T entity)
	{
		Table.Remove(entity);
	}

	public IQueryable<T> GetAll()
	=> Table.AsQueryable();

	public async Task<T?> GetByIdAsync(int id)

	   => await Table.FindAsync(id);


	public IQueryable<T> GetWhere(Func<T, bool> expression)

	  => Table.Where(expression).AsQueryable();


	public async Task<bool> IsExistAsync(int id)
	=> await Table.AnyAsync(t => t.Id == id);

	public async Task<int> SaveAsync()
	=> await _context.SaveChangesAsync();
}