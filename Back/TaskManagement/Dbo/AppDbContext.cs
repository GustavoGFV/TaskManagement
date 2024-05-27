using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using TaskManagement.Dbo.Model;

namespace TaskManagement.Dbo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TaskModel>().HasKey(c => c.Id);

            builder.Entity<CommentModel>().HasKey(c => c.Id);

            // Comments N - 1 Task
            builder.Entity<CommentModel>()
                .HasOne(v => v.IdTask)
                .WithMany()
                .HasForeignKey(u => u.Id);
        }

        public DbSet<TaskModel> Tasks { get; set; }
        public DbSet<CommentModel> Comments { get; set; }
    }
}
