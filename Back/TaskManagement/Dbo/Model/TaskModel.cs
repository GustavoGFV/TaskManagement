using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Dbo.Model
{
    public class TaskModel
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("TaskName")]
        [Required]
        public required string TaskName { get; set; }

        [Column("Description")]
        [Required]
        public required string Description { get; set; }

        [Column("CreatedById")]
        [Required]
        public required int CreatedById { get; set; }

        [Column("AssingedToId")]
        [Required]
        public required int AssingedToId { get; set; }

        [Column("Attachments")]
        public List<Stream>? Attachments { get; set; }

        [Column("CreatedAt")]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Column("UpdatedAt")]
        [Required]
        public DateTime UpdatedAt { get; set; }
    }
}
