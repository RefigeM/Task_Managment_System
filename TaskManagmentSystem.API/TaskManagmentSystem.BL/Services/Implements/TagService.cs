using TaskManagmentSystem.BL.Services.Interfaces;
using TaskManagmentSystem.Core.Entities;
using TaskManagmentSystem.DAL.Context;
using TaskManagmentSystem.DAL.Repositories;

namespace TaskManagmentSystem.BL.Services.Implements
{
	public class TagService : GenericRepository<Tag>, ITagService
	{
		public TagService(ManagmentDbContext _context) : base(_context)
		{
		}
	}
}
