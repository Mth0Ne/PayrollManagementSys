using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PayrollManagementSys.Entity.DTOs.Salaries;
using PayrollManagementSys.Entity.Entities;
using PayrollManagementSys.Service.Extensions;
using PayrollManagementSys.Service.Helpers;
using PayrollManagementSys.Service.Services.Abstract;
using PayrollManagementSys.Service.Services.Concrete;
using System.Security.Claims;

namespace PayrollManagementSys.Web.Controllers
{
    public class PayrollController : Controller
    {
        private readonly IEmployeeService employeeService;
        private readonly ISalaryService salaryService;
        private readonly IPayrollService payrollService;
        private readonly IPdfHelper pdfHelper;
        private readonly IHttpContextAccessor contextAccessor;
        private readonly ClaimsPrincipal _user;
        public PayrollController(IEmployeeService employeeService,ISalaryService salaryService,IPayrollService payrollService, IPdfHelper pdfHelper,IHttpContextAccessor contextAccessor)
        {
            this.employeeService = employeeService;
            this.salaryService = salaryService;
            this.payrollService = payrollService;
            this.pdfHelper = pdfHelper;
            _user = contextAccessor.HttpContext.User;
        }

        [Authorize(Roles = "Superadmin, Admin")]
        [HttpGet]
        public async Task<IActionResult> PayrollEmployee()
        {
            var employees = await employeeService.GetAllEmployeeWithNonDeleted();


            return View(employees);
       
        }
        [Authorize(Roles = "Superadmin, Admin")]
        [HttpGet]
        public async Task<IActionResult> GetPayroll(int employeeId)
        {
            var employee = await employeeService.GetEmployeeById(employeeId);
            var salary = new SalaryAddDto
            {
                PersonelId = employeeId,
                User = employee
            };
                
            return View(salary);
        }

        [Authorize(Roles = "Superadmin, Admin")]
        [HttpPost]
        public async Task<IActionResult> GetPayroll(SalaryAddDto salaryAddDto)
        {
            var salaryAmount =  await payrollService.GetPaymentInfo(salaryAddDto.PersonelId, salaryAddDto.SalaryDate.Date.Month, salaryAddDto.SalaryDate.Date.Year);


            if (salaryAmount != null)
            {
                byte[] documentBytes = pdfHelper.GenerateInvoice(salaryAmount);
                return File(documentBytes, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "Invoice.docx");
            }
            else
            {
                TempData["ErrorPayment"] = "ODEME BILGISI BULUNAMADI!";
                return RedirectToAction("GetPayroll", "Payroll", new { employeeId = salaryAddDto.PersonelId });

            }

        }
        [Authorize(Roles = "User")]
        [HttpGet]
        public async Task<IActionResult> GetEmployeePayroll()
        {

            var employeeId = _user.GetLoggedInUserId();

            var employee = await employeeService.GetEmployeeById(employeeId);
            var salary = new SalaryAddDto
            {
                PersonelId = employeeId,
                User = employee
            };
            return View(salary);
        }

        [Authorize(Roles = "User")]
        [HttpPost]
        public async Task<IActionResult> GetEmployeePayroll(SalaryAddDto salaryAddDto)
        {

            var salaryAmount = await payrollService.GetPaymentInfo(salaryAddDto.PersonelId, salaryAddDto.SalaryDate.Date.Month, salaryAddDto.SalaryDate.Date.Year);
            if (salaryAmount != null)
            {
                byte[] documentBytes = pdfHelper.GenerateInvoice(salaryAmount);
                return File(documentBytes, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "Invoice.docx");
            }
            else
            {
                TempData["ErrorPayment"] = "ODEME BILGISI BULUNAMADI!";
                return RedirectToAction("GetEmployeePayroll", "Payroll");
            }
                      
        }
    }
}
