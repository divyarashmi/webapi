using System.Collections.Generic;
using System.Linq;
using CreatingMembership.BLL;
using CreatingMembership.Data;
using CreatingMembership.Models;
namespace CreatingMembership.BLL
{
    public class MembershipRepository : IMembershipRepository
    {
        MembershipDbContext _context;
        public MembershipRepository(MembershipDbContext context)
        {
            _context=context;
        }
        int IMembershipRepository.Add(Membership membership)
        {
            _context.Add(membership);
            int temp=_context.SaveChanges();
            return temp;
        }

        bool IMembershipRepository.login(string name, string pass)
        {          var temp=_context.memberships.FirstOrDefault(ctr=>ctr.username==name&&ctr.Password==pass);
             if(temp!=null)
             {
                 return true;
             }
            return false;

        
        }
    }
}