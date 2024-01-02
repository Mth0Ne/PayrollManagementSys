using PayrollManagementSys.Entity.DTOs.Departmans;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Entity.DTOs.Employees
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Addres { get; set; }
        public string PhoneNumber { get; set; }
        public string SGKNumara { get; set; }
        public string UserName { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime BirtDate { get; set; }
        public bool IsDeleted { get; set; }
        public WorkDay WorkDay { get; set; }
        public Salary Salary { get; set; }

        public DepartmanDto Departman { get; set; }


    }
}
