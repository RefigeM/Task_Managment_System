using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.DAL.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
	public void Configure(EntityTypeBuilder<Employee> builder)
	{
		builder
			.Property(x => x.Name)
		   .HasMaxLength(32);
		builder
			.Property(e => e.Surname)
			.HasMaxLength(64);
		builder
			.HasMany(e => e.Assignments)
			.WithOne(a => a.Employee)
			.HasForeignKey(a => a.EmployeeId);
	}
}
