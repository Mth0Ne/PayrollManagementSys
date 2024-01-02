using AutoMapper;
using PayrollManagementSys.Data.UnitOfWorks;
using PayrollManagementSys.Entity.DTOs.Departmans;
using PayrollManagementSys.Entity.Entities;
using PayrollManagementSys.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.Services.Concrete
{
    public class DepartmanService: IDepartmanService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public DepartmanService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<DepartmanDto>> GetAllDepartmanAsync()
        {
            var departmans = await unitOfWork.GetRepository<Departman>().GetAllAsync(x=>!x.IsDeleted);
            var map = mapper.Map<List<DepartmanDto>>(departmans);

            return map;
        }
        public async Task DepartmanAddAsync(DepartmanDto departmanDto)
        {
            await unitOfWork.GetRepository<Departman>().DepartmanAddAsync(departmanDto.Name);
            await unitOfWork.SaveAsync();
        }
        public async Task<DepartmanDto> GetDepartmanById(int id)
        {
            var departman = await unitOfWork.GetRepository<Departman>().GetAsync(x=>!x.IsDeleted && x.Id == id);
            var map = mapper.Map<DepartmanDto>(departman);

            return map;
        }
        public async Task DepartmanUpdateAsync(DepartmanDto departmanDto)
        {
            await unitOfWork.GetRepository<Departman>().DepartmanUpdateAsync(departmanDto.Name,departmanDto.Id);
            await unitOfWork.SaveAsync();
           
                    
        }
        public async Task DepartmanSafeDeleteAsync(int departmanId)
        {
            await unitOfWork.GetRepository<Departman>().DepartmanSafeDelete(departmanId);
            await unitOfWork.SaveAsync();
        }
    }
}
