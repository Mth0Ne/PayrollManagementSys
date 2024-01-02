using PayrollManagementSys.Entity.DTOs.Departmans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.Services.Abstract
{
    public interface IDepartmanService
    {
        Task<List<DepartmanDto>> GetAllDepartmanAsync();
        Task DepartmanAddAsync(DepartmanDto departmanDto);
        Task<DepartmanDto> GetDepartmanById(int id);
        Task DepartmanUpdateAsync(DepartmanDto departmanDto);
        Task DepartmanSafeDeleteAsync(int departmanId);


    }
}
