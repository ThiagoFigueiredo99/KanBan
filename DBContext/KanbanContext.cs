using Microsoft.EntityFrameworkCore;
using Projeto;

namespace ConcertKanban.DBContext
{
    public class KanbanContext : DbContext
    {
        public KanbanContext(DbContextOptions<KanbanContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();

            modelBuilder.Entity<Card>()
                .HasOne(card => card.Sprint)
                .WithMany(sprint => sprint.Cards)
                .HasForeignKey(card => card.SprintId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Card>()
                .HasOne(card => card.User)
                .WithMany(user => user.Cards)
                .HasForeignKey(card => card.UserId)
                .OnDelete(DeleteBehavior.Restrict);
             
        } 
         
        public DbSet<Card> Cards { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
