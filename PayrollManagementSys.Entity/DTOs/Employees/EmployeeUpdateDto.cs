using PayrollManagementSys.Entity.DTOs.Departmans;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Entity.DTOs.Employees
{
    public class EmployeeUpdateDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Addres { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string SGKNumara { get; set; }
        public string UserName { get; set; }
        public int DepertmanId { get; set; }
        public IList<DepartmanDto> Departmans { get; set; }
        public int RoleId { get; set; }
        public IList<AppRole> Roles { get; set; }
    }
}
