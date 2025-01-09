using TaskManagmentSystem.Core.Entities;

namespace TaskManagmentSystem.BL.DTOs.AssignmentDto;

public class AssignmentDto
{
	public string Title { get; set; }
	public string Description { get; set; }
	public DateTime DeadLine { get; set; }
	public int? EmployeeId { get; set; }
	public Employee? Employee { get; set; }
	public int TopicId { get; set; }
	public Topic Topic { get; set; }
	public ICollection<Tag> Tags { get; set; }
}
