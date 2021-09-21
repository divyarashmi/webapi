using  System.ComponentModel.DataAnnotations;
namespace EmployeeService1.Model

{
    public class Employee
    {
           
        public int EmployeeCode{get;set;}
        public string EmployeeName{get;set;}
        
        [Range( 18, 50 )]
        public int Employeeage{get;set;}
    }
    
}