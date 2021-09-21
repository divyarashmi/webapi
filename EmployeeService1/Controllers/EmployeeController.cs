using Microsoft.AspNetCore.Mvc;
using EmployeeService1.Model;
namespace EmployeeService1.Controllers
{   
    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {

      [HttpPost("Create")]
      public Employee CreateEmployee(Employee obj)
      {
        return obj;
      }
    }
}