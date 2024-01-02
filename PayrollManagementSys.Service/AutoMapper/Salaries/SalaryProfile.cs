using AutoMapper;
using FluentValidation;
using PayrollManagementSys.Entity.DTOs.Salaries;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.AutoMapper.Salaries
{
    public class SalaryProfile: Profile
    {
        public SalaryProfile()
        {
            CreateMap<SalaryAddDto,Salary>().ReverseMap();
        }
    }
}
