using ContactRepoPrac.Model;
using System.Collections.Generic;
namespace ContactRepoPrac.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> listemployee=new List<Employee>();
        void IEmployeeRepository.Add(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        Employee IEmployeeRepository.Fetch(int Id)
        {
            throw new System.NotImplementedException();
        }

        Employee IEmployeeRepository.GetAll()
        {
            throw new System.NotImplementedException();
        }

        void IEmployeeRepository.Remove(int id)
        {
            throw new System.NotImplementedException();
        }

        void IEmployeeRepository.Update(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}