using TaskManagmentSystem.Core.Entities.Common;

namespace TaskManagmentSystem.Core.Entities;

public class Employee :BaseEntity
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public decimal Salary { get; set; }
	public ICollection<Assignment> Assignments { get; set; }
}
