using DAL;
using Entities;
using System.Transactions;

namespace BLL;

public class EmployeeBusiness: IEmployeeBusiness
{
    private readonly IEmployeeDao _employeeDao;
    public EmployeeBusiness(IEmployeeDao employeeDao)
    {
        _employeeDao = employeeDao;
    }
    

    public void SaveEmployees(List<Employee> employees)
    {
        using (var scope = new TransactionScope())
        {
            foreach (var employee in employees)
            {
                if (employee.IsValid(out string validationMessage))
                {
                    _employeeDao.InsertEmployee(employee);
                }
                else
                {
                    throw new Exception($"Validation error: {validationMessage}");
                }
            }
            scope.Complete(); // Confirma todos los cambios si todo está OK
        }
    }

    public List<Employee> GetAllEmployees()
    {
        return _employeeDao.GetEmployees();
    }
}
