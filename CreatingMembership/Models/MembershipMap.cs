using CreatingMembership.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CreatingMembership.Controllers.Models
{
    public class MembershipMap
    {
       public MembershipMap(EntityTypeBuilder<Membership> entityTypeBuilder )
       {
           entityTypeBuilder.HasKey(t => t.username);
           entityTypeBuilder.Property(t => t.username).HasMaxLength(27).IsRequired();
           entityTypeBuilder.Property(t => t.Password).HasMaxLength(27).IsRequired();
           entityTypeBuilder.Property(t=>t.age).HasMaxLength(1).IsRequired();
       } 
    }
}