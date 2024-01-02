using PayrollManagementSys.Entity.DTOs.Employees;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.Services.Abstract
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetAllEmployeeAsync();
        Task<List<EmployeeDto>> GetAllEmployeeWithNonDeleted();
        Task CreateEmployeeAsync(EmployeeAddDto employeeAddDto);
        Task<EmployeeDto> GetEmployeeById(int id);
        Task<List<AppRole>> GetAllRolesAsync();
        Task EmployeeUpdateAsync(EmployeeUpdateDto employeeUpdateDto);
        Task EmployeeSafeDeleteAsync(int userId);
        Task<int> GetLastEmployeeIdAsync();
    }
}
