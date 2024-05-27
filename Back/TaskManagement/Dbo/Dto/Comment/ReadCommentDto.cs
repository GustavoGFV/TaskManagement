using TaskManagement.Dbo.Model;

namespace TaskManagement.Dbo.Dto.Comment
{
    public class ReadCommentDto
    {
        public int Id { get; set; }
        public required string UserId { get; set; }
        public required string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Edited { get; set; }
        public DateTime UpdatedAt => DateTime.Now;
        public required TaskModel IdTask { get; set; }
    }
}
