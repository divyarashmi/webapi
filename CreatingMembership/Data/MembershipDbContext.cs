using Microsoft.EntityFrameworkCore;
using CreatingMembership.Models;
using CreatingMembership.Controllers.Models;

namespace CreatingMembership.Data
{
    public class MembershipDbContext:DbContext
    {
       public DbSet<Membership> memberships{get;set;}
        public MembershipDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new MembershipMap(modelBuilder.Entity<Membership>());
        }
    }
}