using Microsoft.AspNetCore.Mvc;
using PayrollManagementSys.Data.UnitOfWorks;
using PayrollManagementSys.Entity.Entities;
using PayrollManagementSys.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.Services.Concrete
{
    public class DashboardService: IDashboardService
    {
        private readonly IUnitOfWork unitOfWork;

        public DashboardService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<AverageSalaryByDepartment>> GetAverageSalaryByDepartmentsAsync()
        {
            try
            {
                var averageSalary = await unitOfWork.GetRepository<AverageSalaryByDepartment>().GetAverageSalaryByDepartmentAsync();

                

                return averageSalary;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAverageSalaryByDepartmentsAsync: {ex.Message}");
                throw; // Rethrow the exception
            }
        }

        public async Task<int> GetTotalEmployee()
        {
            var totalemployee = await unitOfWork.GetRepository<TotalEmployees>().GetTotalEmployeeAsync();
            return totalemployee;
        }
        public async Task<int> GetTotalDepartman()
        {

            var totalDepartman = await unitOfWork.GetRepository<TotalDepartmanCount>().GetTotalDepartmanAsync();
            return totalDepartman;
        }

    }
}
