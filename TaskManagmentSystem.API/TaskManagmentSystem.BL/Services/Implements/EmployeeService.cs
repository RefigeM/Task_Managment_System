using TaskManagmentSystem.BL.Services.Interfaces;
using TaskManagmentSystem.Core.Entities;
using TaskManagmentSystem.DAL.Context;
using TaskManagmentSystem.DAL.Repositories;

namespace TaskManagmentSystem.BL.Services.Implements;

public class EmployeeService : GenericRepository<Employee>, IEmployeeService
{
	public EmployeeService(ManagmentDbContext _context) : base(_context)
	{
	}
}
