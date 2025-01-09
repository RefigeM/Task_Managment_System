using Microsoft.EntityFrameworkCore;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.DAL.Context
{
	public class ManagmentDbContext : DbContext
	{
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Assignment> Assignments { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<Topic> Topics { get; set; }
		public ManagmentDbContext(DbContextOptions options) : base(options)
		{
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ManagmentDbContext).Assembly);
			base.OnModelCreating(modelBuilder);
		}
	}
}
