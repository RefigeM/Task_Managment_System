using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.DAL.Configurations;

public class TopicConfiguration : IEntityTypeConfiguration<Topic>
{
	public void Configure(EntityTypeBuilder<Topic> builder)
	{
		builder
		 .HasIndex(t => t.Name)
		 .IsUnique();
		builder
			.Property(t => t.Name)
			.HasMaxLength(32);
		builder
			.HasMany(t => t.Assignments)
			.WithOne(t => t.Topic)
			.HasForeignKey(t => t.TopicId);
	}
}
