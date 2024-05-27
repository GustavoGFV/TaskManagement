using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Dbo.Dto.Task
{
    public class CreateTaskDto
    {
        [Required]
        public required string TaskName { get; set; }

        [Required]
        public required string Description { get; set; }

        [Required]
        public required int CreatedById { get; set; }

        [Required]
        public required int AssingedToId { get; set; }

        public List<Stream>? Attachments { get; set; }

        public DateTime CreatedAt => DateTime.Now;

        public DateTime UpdatedAt => DateTime.Now;
    }
}
