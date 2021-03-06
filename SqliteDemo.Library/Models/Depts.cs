using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SqliteDemo
{
    [Table("Dept")]
    public class Depts
    {
        [Key]
        [Required]
        public int deptid { get; set; }

        [StringLength(50)]
        public string dname { get; set; }

        [StringLength(50)]
        public string location { get; set; }
    }
}
