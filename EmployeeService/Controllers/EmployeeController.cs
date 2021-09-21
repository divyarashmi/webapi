using Microsoft.AspNetCore.Mvc;
using EmployeeService.Model;
using System.Collections.Generic;

namespace EmployeeService.Controllers
{
    [Route("[controller]")]
    public class EmployeeController: ControllerBase
    {
        [HttpGet("info")]
        public List<Employee> Details()
        {
            EmployeeData obj =new EmployeeData();
            List<Employee> temp=obj.EmployeeDetails();
            return temp;
        }
        
    }
}