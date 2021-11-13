using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DBAccess.Entities
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        // Foreign key   
        [Display(Name = "Department")]
        public virtual int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Departments { get; set; }
    }
}
