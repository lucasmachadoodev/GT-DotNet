using GT_Visiontec.Models;
using Microsoft.EntityFrameworkCore;

namespace GT_Visiontec.Context
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GroupUser>()
              .HasKey(m => new { m.GroupId, m.UserId } );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Group> Group { get; set; }

        public DbSet<GroupUser> GroupUser { get; set; }

        public DbSet<User> User { get; set; }
    }
}
