using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PayrollManagementSys.Data.UnitOfWorks;
using PayrollManagementSys.Entity.DTOs.Employees;
using PayrollManagementSys.Entity.DTOs.Salaries;
using PayrollManagementSys.Entity.Entities;
using PayrollManagementSys.Service.Services.Abstract;

namespace PayrollManagementSys.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IEmployeeService employeService;
        private readonly IDepartmanService departmanService;
        private readonly ISalaryService salaryService;
        private readonly IMapper mapper;
        private readonly IValidator<AppUser> validator;
        private readonly IValidator<EmployeeDto> validatorUpdate;
        private readonly IValidator<Salary> salaryValidator;

        public EmployeeController(IEmployeeService employeService,IDepartmanService departmanService,ISalaryService salaryService,
            IMapper mapper,IValidator<AppUser> validator,IValidator<EmployeeDto> validatorUpdate,IValidator<Salary> salaryValidator)
        {

            this.employeService = employeService;
            this.departmanService = departmanService;
            this.salaryService = salaryService;
            this.mapper = mapper;
            this.validator = validator;
            this.validatorUpdate = validatorUpdate;
            this.salaryValidator = salaryValidator;
        }
        [Authorize(Roles = "Superadmin, Admin")]
        public async Task<IActionResult> Employees()
        {
            var employees = await employeService.GetAllEmployeeAsync();
            
            return View(employees);
        }

        [Authorize(Roles = "Superadmin, Admin")]
        [HttpGet]
        public async Task<IActionResult> EmployeeAdd()
        {
            var departmans = await departmanService.GetAllDepartmanAsync();
            var roles = await employeService.GetAllRolesAsync();

            return View(new EmployeeAddDto { Departmans = departmans,Roles = roles });
        }

        [Authorize(Roles ="Superadmin, Admin")]
        [HttpPost]
        public async Task<IActionResult> EmployeeAdd(EmployeeAddDto employeeAddDto)
        {
            var departmans = await departmanService.GetAllDepartmanAsync();
            var roles = await employeService.GetAllRolesAsync();

            var map = mapper.Map<AppUser>(employeeAddDto);
            var result =  await validator.ValidateAsync(map);
            if (result.IsValid)
            {
                await employeService.CreateEmployeeAsync(employeeAddDto);
               
                return RedirectToAction("Employees", "Employee");
            }
            else
            {
                result.AddToModelState(this.ModelState);

            }
            return View(new EmployeeAddDto { Departmans=departmans,Roles = roles});
           
        }

        [Authorize(Roles = "Superadmin, Admin")]
        [HttpGet]
        public async Task<IActionResult> EmployeeUpdate(int employeeId)
        {
            var employees = await employeService.GetEmployeeById(employeeId);

            var departmans = await departmanService.GetAllDepartmanAsync();
            
            var roles = await employeService.GetAllRolesAsync();
            var map = mapper.Map<EmployeeUpdateDto>(employees);
            map.Roles = roles;
            map.Departmans = departmans;
            return View(map);
        }

        [Authorize(Roles = "Superadmin, Admin")]
        [HttpPost]
        public async Task<IActionResult> EmployeeUpdate(EmployeeUpdateDto employeeUpdateDto)
        {
            var employees = await employeService.GetEmployeeById(employeeUpdateDto.Id);

            var departmans = await departmanService.GetAllDepartmanAsync();

            var map = mapper.Map<EmployeeDto>(employeeUpdateDto);
            var result = await validatorUpdate.ValidateAsync(map);
            if (result.IsValid)
            {
                await employeService.EmployeeUpdateAsync(employeeUpdateDto);
                return RedirectToAction("Employees", "Employee");
            }
            else
                result.AddToModelState(this.ModelState);

;
            var roles = await employeService.GetAllRolesAsync();
            var updatemap = mapper.Map<EmployeeUpdateDto>(employees);
            updatemap.Roles = roles;
            updatemap.Departmans = departmans;
            return View(updatemap);
        }
        public async Task<IActionResult> EmployeeDelete(int userId)
        {
            await employeService.EmployeeSafeDeleteAsync(userId);
            return RedirectToAction("Employees", "Employee");
        }

        [Authorize(Roles = "Superadmin, Admin")]
        [HttpPost]
        public async Task<IActionResult> EmployeeSalary(WorkDaySalaryViewModel viewModel)
        {
            var Id = await employeService.GetLastEmployeeIdAsync();
            var map = mapper.Map<Salary>(viewModel);
            var result = await salaryValidator.ValidateAsync(map);
            if (result.IsValid)
            {
                await salaryService.SalaryAddAsync(viewModel.Salary);
                return RedirectToAction("Employees", "Employee");
            }
            else
                result.AddToModelState(this.ModelState);
            
            return View(new SalaryAddDto { PersonelId = Id });
        }
    }
}
