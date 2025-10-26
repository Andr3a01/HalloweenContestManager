using HalloweenContestManager.Modelds.Entity;
using Microsoft.EntityFrameworkCore;

namespace HalloweenContestManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; } = null!;
        public DbSet<Role> Roles { get; set; } = null!;
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>()
                .HasMany(x => x.Roles)
                .WithMany(x => x.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "USER_ROLES_MAP",
                    j => j
                        .HasOne<Role>()
                        .WithMany()
                        .HasForeignKey("ROLE_ID")
                        .HasConstraintName("FK_USER_ROLES_MAP_USER_ROLES"),
                    j => j 
                        .HasOne<UserAccount>()
                        .WithMany()
                        .HasForeignKey("USER_ID") 
                        .HasConstraintName("FK_USER_ROLES_MAP_USER_ACCOUNT")
                );
        }
        public DbSet<HalloweenContestManager.Modelds.Entity.Role> Role { get; set; } = default!;
    }
}
