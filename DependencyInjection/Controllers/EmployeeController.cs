using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Repository;
using DependencyInjection.Models;
namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class EmployeeController:ControllerBase
    
    {
        IEmployeeList list1;
        public EmployeeController(IEmployeeList  list2) 
        {
            list1=list2;
        }
        [HttpPost]
        public Employee CreateEmployeeData(Employee temp)
        {
            var t = list1.CreateEmployee(temp);
            if(t==0)
            {

            }
            return temp;
        }
    }
}