using HalloweenContestManager.Modelds.Entity;
using Microsoft.EntityFrameworkCore;

namespace HalloweenContestManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserAccount> UserAccounts;
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }
    }
}
