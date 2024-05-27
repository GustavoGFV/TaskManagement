using System.ComponentModel.DataAnnotations;
using TaskManagement.Dbo.Model;

namespace TaskManagement.Dbo.Dto.Comment
{
    public class CreateCommentDto
    {
        [Required]
        public required string UserId { get; set; }
        [Required]
        public required string Content { get; set; }
        public DateTime CreatedAt => DateTime.Now;
        public bool Edited => false;
        public DateTime UpdatedAt => DateTime.Now;
        [Required]
        public required TaskModel IdTask { get; set; }
    }
}
