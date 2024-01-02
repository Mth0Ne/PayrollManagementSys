using PayrollManagementSys.Data.UnitOfWorks;
using PayrollManagementSys.Entity.Entities;
using PayrollManagementSys.Service.Helpers;
using PayrollManagementSys.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.Services.Concrete
{
    public class PayrollService: IPayrollService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IPdfHelper pdfHelper;

        public PayrollService(IUnitOfWork unitOfWork,IPdfHelper pdfHelper )
        {
            this.unitOfWork = unitOfWork;
            this.pdfHelper = pdfHelper;
        }
        public async Task<PaymentInfo> GetPaymentInfo(int personelId, int istenilenAy, int istenilenYıl)
        {
            var paymentInfo = await unitOfWork.GetRepository<PaymentInfo>().GetPayrollAsync(personelId, istenilenAy, istenilenYıl);
            return paymentInfo;
        }
        //public async Task<MemoryStream> CreatePayrollAsync(double payment)
        //{
        //    var payroll = await pdfHelper.GeneratePdf(payment);
        //    return payroll;
        //}
    }
}
