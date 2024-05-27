using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Dbo.Model
{
    [Table("Comments")]
    public class CommentModel
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("UserId")]
        [Required]
        public required string UserId { get; set; }

        [Column("Content")]
        [Required]
        public required string Content { get; set; }

        [Column("CreatedAt")]
        [Required]
        public DateTime CreatedAt { get; set; }

        [Column("Edited")]
        [Required]
        public bool Edited { get; set; }

        [Column("UpdatedAt")]
        [Required]
        public DateTime UpdatedAt { get; set; }

        [Column("IdTask")]
        [Required]
        public required TaskModel IdTask { get; set; }
    }
}
