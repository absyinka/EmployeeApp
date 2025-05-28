using EmployeeApp.Data;

namespace EmployeeApp.Repository;

public interface IEmployeeRepository
{
    Task<bool> AddEmployee(Employee employee);
    Task<List<Employee>> GetAllEmployees();
    Task<Employee> GetEmployeeById(Guid id);
    Task<bool> UpdateEmployee(Employee employee);
    Task<bool> DeleteEmployee(Guid id);
    Task<bool> IsEmployeeExist(string email);
}
