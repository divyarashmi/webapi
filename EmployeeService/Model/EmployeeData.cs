using System.Collections.Generic;
using EmployeeService.Model;
namespace EmployeeService.Model
{
    public class EmployeeData
    {
        public List<Employee> EmployeeDetails()
        {
            List<Employee> obj =new List<Employee>();
            obj.Add(new Employee
            {
                pho=256,
                name="niks"

            });
            obj.Add(new Employee
            {
                pho=156,
                name="karan"

            });
            return obj;
        }
    }
}