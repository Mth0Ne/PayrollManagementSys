using PayrollManagementSys.Entity.DTOs.Employees;
using PayrollManagementSys.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PayrollManagementSys.Entity.DTOs.Salaries
{
    public class SalaryAddDto
    {
        public int PersonelId { get; set; }
        public double SalaryCoefficient { get; set; }
        public double TaxDeduction { get; set; }
        public double SgkDeduction { get; set; }
        public float AdditionalPayments { get; set; }
        public DateTime SalaryDate { get; set; }
        public WorkDay workDay { get; set; }
        public EmployeeDto User { get; set; }
     
    }
}
