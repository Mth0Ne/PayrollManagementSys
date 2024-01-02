using AutoMapper;
using PayrollManagementSys.Entity.DTOs.Employees;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.AutoMapper.Employees
{
    public class EmployeeProfile: Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeDto, AppUser>().ReverseMap();
            CreateMap<EmployeeLoginDto, AppUser>().ReverseMap();
            CreateMap<EmployeeAddDto,AppUser>().ReverseMap();
            CreateMap<EmployeeUpdateDto,AppUser>().ReverseMap();
            CreateMap<EmployeeUpdateDto,EmployeeDto>().ReverseMap();
        }
    }
}
