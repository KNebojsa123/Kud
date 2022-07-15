using EmployeeManagementAsp.ViewModels;
using System.Collections.Generic;

namespace EmployeeManagementAsp.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployee();
        Employee Add(Employee employee);
        Employee Update(Employee employeeChanges);
        Employee Delete(int Id);
    }
}
