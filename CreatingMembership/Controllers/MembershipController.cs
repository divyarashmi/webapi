using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CreatingMembership.Models;
using CreatingMembership.BLL;
using Microsoft.Extensions.Logging;
using AutoMapper;

namespace CreatingMembership.Controllers
{
   [ApiController]
    [Route("Taazaa/[controller]")]
  
    public class MembershipController:ControllerBase
    {
        IMembershipRepository _imembershiprepository;
        IMapper imapper;
        public MembershipController(IMembershipRepository imembershiprepository,IMapper _imapper)
        {
            _imembershiprepository=imembershiprepository;
            imapper=_imapper;
        }
        [HttpPost("AddMembership")]
        public IActionResult CreatingMembership(UserDTO userDTO)
        {
           var membershipmap= imapper.Map<Membership>(userDTO);
            //int res =_imembershiprepository.Add(membership);
           // Membership obj=new Membership();
        //   obj.Id=membership.Id;
        //   obj.Password=membership.Password;
        //   obj.username=membership.username;
        //   obj.age=membership.age;

          var temp= _imembershiprepository.Add(membershipmap);
          return Ok(temp);
        }
        [HttpGet("login")]
        public IActionResult LoginUser(string nm , string Password)
        {
            var temp=_imembershiprepository.login(nm,Password);
            return Ok(temp);
        }
    }
}