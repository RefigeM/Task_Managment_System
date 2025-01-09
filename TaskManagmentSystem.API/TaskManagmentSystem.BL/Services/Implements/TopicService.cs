using TaskManagmentSystem.BL.Services.Interfaces;
using TaskManagmentSystem.Core.Entities;
using TaskManagmentSystem.DAL.Context;
using TaskManagmentSystem.DAL.Repositories;

namespace TaskManagmentSystem.BL.Services.Implements
{
	public class TopicService : GenericRepository<Topic>, ITopicService
	{
		public TopicService(ManagmentDbContext _context) : base(_context)
		{
		}
	}
}
