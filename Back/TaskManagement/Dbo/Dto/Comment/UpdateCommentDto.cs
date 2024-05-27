using System.ComponentModel.DataAnnotations;
using TaskManagement.Dbo.Model;

namespace TaskManagement.Dbo.Dto.Comment
{
    public class UpdateCommentDto
    {
        [Required]
        public required string Content { get; set; }
        public bool Edited => true;
        [Required]
        public required TaskModel IdTask { get; set; }
    }
}
