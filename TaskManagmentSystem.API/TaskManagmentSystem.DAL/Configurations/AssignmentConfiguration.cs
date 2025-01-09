using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.DAL.Configurations
{
	public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
	{
		public void Configure(EntityTypeBuilder<Assignment> builder)
		{
			builder
			   .Property(a => a.Title)
			   .HasMaxLength(64);
			builder
				.Property(a => a.Description)
				.HasMaxLength(128);
			builder
				.HasMany(a => a.Tags)
				.WithMany(t => t.Assignments);
			builder
				.HasOne(a => a.Employee)
				.WithMany(e => e.Assignments)
				.HasForeignKey(a => a.EmployeeId);
			builder
				.HasOne(a => a.Topic)
				.WithMany(e => e.Assignments)
				.HasForeignKey(a => a.TopicId);
		}
	}
}
