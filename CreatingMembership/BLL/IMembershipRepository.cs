using System.Collections.Generic;
using CreatingMembership.Models;
namespace CreatingMembership.BLL
{
    public interface IMembershipRepository
    {
        int Add(Membership membership);
       bool login(string username,string Password);
         
    }
}