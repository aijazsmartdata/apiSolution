using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBAccess.Entities
{
    internal class Salary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public virtual int EmpId { get; set; }
        public int salary { get; set; }
        [ForeignKey("EmpId")]
        public virtual Employee Employees { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
