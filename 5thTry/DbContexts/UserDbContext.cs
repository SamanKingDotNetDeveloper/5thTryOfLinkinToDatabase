using _5thTry.Models;
using Microsoft.EntityFrameworkCore;

namespace _5thTry.DbContexts
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options)
            :base(options){}
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
