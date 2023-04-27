using Microsoft.EntityFrameworkCore;

namespace ConsoleApp_db.Models
{
    public class UsersContext : DbContext, IUserContext
    {
        public DbSet<User> Users { get; set; }

        public UsersContext(DbContextOptions<UsersContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}