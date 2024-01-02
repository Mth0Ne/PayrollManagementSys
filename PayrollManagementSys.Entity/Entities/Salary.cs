using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Entity.Entities
{
    public class Salary
    {
        [Key]
        public int SalaryId { get; set; }
      
        public int PersonelId { get; set; }
        public AppUser Personel { get; set; }   
        public double SalaryCoefficient { get; set; }
        public DateTime? SalaryDate { get; set; }
        public double TaxDeduction { get; set; }
        public double SgkDeduction { get; set; }
        public double? AdditionalPayments { get; set; }
        
       
    }
}
