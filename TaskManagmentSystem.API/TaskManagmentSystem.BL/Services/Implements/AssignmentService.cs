using TaskManagmentSystem.BL.Services.Interfaces;
using TaskManagmentSystem.Core.Entities;
using TaskManagmentSystem.Core.Repositories;
using TaskManagmentSystem.DAL.Context;
using TaskManagmentSystem.DAL.Repositories;

namespace TaskManagmentSystem.BL.Services.Implements
{
	public class AssignmentService : GenericRepository<Assignment>, IAssignmentService
	{
		public AssignmentService(ManagmentDbContext _context) : base(_context)
		{
		}
	}
}
