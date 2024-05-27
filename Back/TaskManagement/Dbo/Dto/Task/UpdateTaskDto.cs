namespace TaskManagement.Dbo.Dto.Task
{
    public class UpdateTaskDto
    {
        public int Id { get; set; }
        public string? TaskName { get; set; }
        public string? Description { get; set; }
        public int? AssingedToId { get; set; }
        public List<Stream>? Attachments { get; set; }
        public DateTime UpdatedAt => DateTime.Now;
    }
}
