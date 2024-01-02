using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.Services.Abstract
{
    public interface IPayrollService
    {
        Task<PaymentInfo> GetPaymentInfo(int personelId, int istenilenAy, int istenilenYıl);
        //Task<MemoryStream> CreatePayrollAsync(double payment);
        
    }
}
