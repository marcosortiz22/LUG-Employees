using DAL.Helpers;
using Entities;
using System.Data;

namespace DAL;

public class EmployeeDao: IEmployeeDao
{
    private DataAccessHelper _dataAccessHelper;
    public EmployeeDao(DataAccessHelper dataAccessHelper) 
    {
        _dataAccessHelper = dataAccessHelper;
    }

    public void InsertEmployee(Employee employee)
    {
        try
        {
            var parameters = new Dictionary<string, object> {
            { "@LastNameFirstName", employee.LastNameFirstName },
            { "@PersonalId", employee.PersonalId },
            { "@GrossSalary",employee.GrossSalary },
            };

            string query = "INSERT INTO Employees (LastNameFirstName, PersonalId, GrossSalary) VALUES (@LastNameFirstName, @PersonalId, @GrossSalary)";

            _dataAccessHelper.ExecuteNonQuery(query, parameters);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        
    }

    public List<Employee> GetEmployees()
    {
        var employees = new List<Employee>();

        try
        {
            using (var connection = _dataAccessHelper.GetConnection())
            {
                string query = "SELECT LastNameFirstName, PersonalId, GrossSalary FROM Employees";
                var command = _dataAccessHelper.GetCommand(query, connection);

                connection.Open();
                using (var reader = _dataAccessHelper.GetDataReader(command))
                {
                    while (reader.Read())
                    {
                        employees.Add(new Employee
                        {
                            LastNameFirstName = reader.GetString("LastNameFirstName"),
                            PersonalId = reader.GetString("PersonalId"),
                            GrossSalary = reader.GetDecimal("GrossSalary")
                        });
                    }
                }
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return employees;
    }
}
