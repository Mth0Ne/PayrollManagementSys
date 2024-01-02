using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using PayrollManagementSys.Data.UnitOfWorks;
using PayrollManagementSys.Entity.DTOs.Departmans;
using PayrollManagementSys.Entity.DTOs.Employees;
using PayrollManagementSys.Entity.Entities;
using PayrollManagementSys.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.Services.Concrete
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;

        public EmployeeService(IUnitOfWork unitOfWork,IMapper mapper,UserManager<AppUser> userManager,RoleManager
            <AppRole> roleManager)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task<List<EmployeeDto>> GetAllEmployeeAsync()
        {
            var employees = await unitOfWork.GetRepository<AppUser>().GetAllAsync(null,x=>x.Departman);
            var map = mapper.Map<List<EmployeeDto>>(employees);

            return map;
        }
        public async Task<List<EmployeeDto>> GetAllEmployeeWithNonDeleted()
        {

            var employees = await unitOfWork.GetRepository<AppUser>().GetAllAsync(x=>!x.IsDeleted,x=>x.Departman);
            var map = mapper.Map<List<EmployeeDto>>(employees);

            return map;
        }
        public async Task<string> GetEmployeeRoleLogin(string email)
        {
            throw new NotImplementedException();
        }
        public async Task CreateEmployeeAsync(EmployeeAddDto employeeAddDto)
        {
            var passwordhasher = new PasswordHasher<AppUser>();
            string hashedPassword = passwordhasher.HashPassword(null, employeeAddDto.PasswordHash);
            await unitOfWork.GetRepository<AppUser>().EmployeeAddAsync(employeeAddDto, hashedPassword);


        }
        public async Task<EmployeeDto> GetEmployeeById(int id)
        {
            var employee = await unitOfWork.GetRepository<AppUser>().GetAsync(x=>!x.IsDeleted && x.Id == id);
            var map = mapper.Map<EmployeeDto>(employee);
            return map;

        }
        public async Task<List<AppRole>> GetAllRolesAsync()
        {
            var roles = await unitOfWork.GetRepository<AppRole>().GetAllAsync();
            return roles;
        }
        public async Task EmployeeUpdateAsync(EmployeeUpdateDto employeeUpdateDto)
        {
            await unitOfWork.GetRepository<AppUser>().EmployeeUpdateAsync(employeeUpdateDto);
        }
        public async Task EmployeeSafeDeleteAsync(int userId)
        {
            await unitOfWork.GetRepository<AppUser>().EmployeeSafeDeleteAsync(userId);
            await unitOfWork.SaveAsync();
        }
        public async Task<int> GetLastEmployeeIdAsync()
        {
            return await unitOfWork.GetRepository<AppUser>().GetLastEmployeeIdAsync();
        }
    }
}
