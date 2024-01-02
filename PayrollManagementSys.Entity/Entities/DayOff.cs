using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Entity.Entities
{
    public class DayOff
    {
        [Key]
        public int Id { get; set; }
    
        public int PersonelId { get; set; }
        public AppUser Personel { get; set; }
        public string Type { get; set; }
        public DateTime StartedDate_DayOff { get; set; }
        public DateTime EndedDate_DayOff { get;set; }

    }
}
