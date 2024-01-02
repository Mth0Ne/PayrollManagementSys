using AutoMapper;
using PayrollManagementSys.Entity.DTOs.Departmans;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.AutoMapper.Departmans
{
    public class DepartmanProfile: Profile
    {
        public DepartmanProfile()
        {
            CreateMap<DepartmanDto, Departman>().ReverseMap();
        }
    }
}
