using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using PayrollManagementSys.Data.UnitOfWorks;
using PayrollManagementSys.Entity.DTOs.Employees;
using PayrollManagementSys.Entity.DTOs.Salaries;
using PayrollManagementSys.Entity.Entities;
using PayrollManagementSys.Service.Services.Abstract;

namespace PayrollManagementSys.Web.Controllers
{
    public class SalaryController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IEmployeeService employeeService;
        private readonly ISalaryService salaryService;
        private readonly IMapper mapper;

        public SalaryController(IUnitOfWork unitOfWork,IEmployeeService employeeService,ISalaryService salaryService,IMapper mapper )
        {
            this.unitOfWork = unitOfWork;
            this.employeeService = employeeService;
            this.salaryService = salaryService;
            this.mapper = mapper;
        }
        [Authorize(Roles = "Superadmin,Admin")]
        [HttpGet]
        public async Task<IActionResult> EmployeSalary()
        {
            var employees = await employeeService.GetAllEmployeeWithNonDeleted();
          
          
            return View(employees);
        }

        [Authorize(Roles = "Superadmin,Admin")]
        [HttpPost]
        public async Task<IActionResult> EmployeSalaryPost(int selectedMonth)
        {

            await salaryService.CalculateSalaryAsync();
            var id = selectedMonth;
            return RedirectToAction("EmployeSalary", "Salary");

        }

        [Authorize(Roles = "Superadmin,Admin")]
        [HttpGet]
        public async Task<IActionResult> SalaryEdit(int employeeId)
        {
            var employee = await employeeService.GetEmployeeById(employeeId);
            var viewModel = new WorkDaySalaryViewModel
            {
                WorkDay = new WorkDay { PersonelId = employeeId},
                
                Salary = new SalaryAddDto { PersonelId= employeeId }
            };

            return View(viewModel);
        }

        [Authorize(Roles = "Superadmin,Admin")]
        [HttpPost]
        public async Task<IActionResult> SalaryEdit(WorkDaySalaryViewModel viewModel)
        {

            var viewModel1 = new WorkDaySalaryViewModel
            {
                WorkDay = new WorkDay { PersonelId = viewModel.WorkDay.PersonelId },

                Salary = new SalaryAddDto { PersonelId = viewModel.WorkDay.PersonelId }
            };


            bool isSuccess = await salaryService.InsertWorkDayAsync(viewModel);
            bool isSuccessSalary = await salaryService.SalaryAddAsync(viewModel.Salary);


            if (isSuccess)
            {
                
                if (isSuccessSalary)
                {
                    return RedirectToAction("Index", "Home"); // Adjust as needed

                }
                else 
                {
                    TempData["ErrorSalary"] = "MAAS BILGI ISLEMLERI SIRASINDA HATA OLUSTU!";
                    return View(viewModel1); // Adjust as needed
                }
            }
            else
            {
                // Return an error response or handle the error in some way
                TempData["Error"] = "AYNI AY VE YILDA ÇALISMA ZAMANI EKLENEMEZ!";
                return View(viewModel1); // Adjust as needed
            }


        }
  
    }
}
