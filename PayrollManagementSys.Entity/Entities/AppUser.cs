using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Entity.Entities
{
    public class AppUser : IdentityUser<int>
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirtDate { get; set; }
        public string Gender { get; set; }
        [ForeignKey("Departman")]
        public int DepertmanId { get; set; }
        public virtual Departman Departman { get; set; }
        public string Addres { get; set; }
        public DateTime StartedDate { get; set; } = DateTime.Now;
        public string SGKNumara { get; set; }
        public virtual bool IsDeleted { get; set; } = false;
        public ICollection<Salary> Salaries { get; set; }
        public ICollection<PaymentInfo> PaymentInfos { get; set; }
        public ICollection<WorkDay> WorkDays { get; set; }
        public ICollection<DayOff> DayOffs { get; set; }
    }
}
