using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Dbo.Dto.Task
{
    public class ReadTaskDto
    {
        public int Id { get; set; }
        public required string TaskName { get; set; }
        public required string Description { get; set; }
        public required int CreatedById { get; set; }
        public required int AssingedToId { get; set; }
        public List<Stream>? Attachments { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
