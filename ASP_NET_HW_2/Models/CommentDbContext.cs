using System.Data.Entity;

namespace ASP_NET_HW_2.Models
{
    public class CommentDbContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
    }
}