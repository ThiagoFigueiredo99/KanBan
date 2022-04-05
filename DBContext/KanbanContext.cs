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
        
        public DbSet<Card> Cards { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
