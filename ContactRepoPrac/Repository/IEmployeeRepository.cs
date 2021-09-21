using ContactRepoPrac.Model;
namespace ContactRepoPrac.Repository
{
    public interface IEmployeeRepository
    {
       void Add(Employee employee);
       void Update(Employee employee);

       Employee GetAll();
       Employee Fetch(int Id);
       void Remove(int id);

    }
}