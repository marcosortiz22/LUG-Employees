using Entities;

namespace BLL;

public interface IEmployeeBusiness
{
    void SaveEmployees(List<Employee> employees);
    List<Employee> GetAllEmployees();
}
