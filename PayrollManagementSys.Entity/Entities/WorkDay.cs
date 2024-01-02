using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Entity.Entities
{
    public class WorkDay
    {
        [Key]
        public int WorkDayId { get; set; }

        public int PersonelId { get; set; }
        public AppUser Personel { get; set; }
        public DateTime? WorkDate { get; set; }
        public double WorkTime { get; set; }
    }
}
