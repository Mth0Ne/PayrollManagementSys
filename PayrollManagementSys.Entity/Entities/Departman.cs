using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollManagementSys.Entity.Entities
{
    public class Departman
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
     
        public virtual bool IsDeleted { get; set; } = false;
        public ICollection<AppUser> Users { get; set; }
    }
}
