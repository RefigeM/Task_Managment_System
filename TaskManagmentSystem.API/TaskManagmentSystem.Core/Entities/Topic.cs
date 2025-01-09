using TaskManagmentSystem.Core.Entities.Common;

namespace TaskManagmentSystem.Core.Entities;

public class Topic :BaseEntity
{
	public string Name { get; set; }
	public ICollection<Assignment> Assignments { get; set; }
}
