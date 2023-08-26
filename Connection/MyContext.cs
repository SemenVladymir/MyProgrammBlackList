using Microsoft.EntityFrameworkCore;
using MyProgrammBlackList.Models;
using User = MyProgrammBlackList.Models.User;

namespace Numismatics.Connection
{
    internal class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<App> Apps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MV43C0T;Database=BlackListApps;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
