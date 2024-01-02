using Microsoft.EntityFrameworkCore.Metadata;
using PayrollManagementSys.Data.UnitOfWorks;
using PayrollManagementSys.Entity.Entities;
using PayrollManagementSys.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Service.Services.Concrete
{
    public class RoleService: IRoleService
    {
        private readonly IUnitOfWork unitOfWork;

        public RoleService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task InsertRoleAsync(AppRole role)
        {
            await unitOfWork.GetRepository<AppRole>().InserRole(role.Name);
            await unitOfWork.SaveAsync();
        }
    }
}
