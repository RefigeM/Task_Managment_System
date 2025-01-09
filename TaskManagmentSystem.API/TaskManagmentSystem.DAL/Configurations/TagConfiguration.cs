using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.DAL.Configurations;

public class TagConfiguration : IEntityTypeConfiguration<Tag>
{
	public void Configure(EntityTypeBuilder<Tag> builder)
	{
		builder
			.HasIndex(t => t.Name)
			.IsUnique();
		builder
			.Property(t => t.Name)
			.HasMaxLength(64);
		builder
			.HasMany(t => t.Assignments)
			.WithMany(t => t.Tags);
	}
}
