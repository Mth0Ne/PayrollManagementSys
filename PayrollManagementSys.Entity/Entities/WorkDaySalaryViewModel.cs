using PayrollManagementSys.Entity.DTOs.Salaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Entity.Entities
{
    public class WorkDaySalaryViewModel
    {
        public WorkDay WorkDay { get; set; }
        public SalaryAddDto Salary { get; set; }
    }
}
