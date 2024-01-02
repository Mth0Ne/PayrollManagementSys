using PayrollManagementSys.Entity.DTOs.Salaries;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.Services.Abstract
{
    public interface ISalaryService
    {
        Task<bool> SalaryAddAsync(SalaryAddDto salaryAddDto);
        Task<bool> InsertWorkDayAsync(WorkDaySalaryViewModel viewModel);
        Task CalculateSalaryAsync();
        Task<List<WorkDay>> GetWorkDateAsync();
        Task<PaymentInfo> GetPaymentInfo(int personelId, int istenilenAy, int istenilenYıl);
    }
}
