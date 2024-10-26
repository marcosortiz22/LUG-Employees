using Entities;

namespace DAL;

public interface IEmployeeDao
{
    void InsertEmployee(Employee employee);
    List<Employee> GetEmployees();
}
