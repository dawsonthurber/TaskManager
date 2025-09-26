using Microsoft.EntityFrameworkCore;
using TaskManager.Data.Models;

namespace TaskManager.Data
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions<TaskManagerContext> options) : base(options)
        {

        }

        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attachment>().ToTable("Attachment");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Models.Task>().ToTable("Task");
        }
    }
}