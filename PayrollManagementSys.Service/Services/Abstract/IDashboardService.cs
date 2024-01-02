using Microsoft.AspNetCore.Mvc;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.Services.Abstract
{
    public interface IDashboardService
    {
        Task<List<AverageSalaryByDepartment>> GetAverageSalaryByDepartmentsAsync();

        Task<int> GetTotalEmployee();
        Task<int> GetTotalDepartman();
    }
}
