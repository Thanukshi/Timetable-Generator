using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTimeApp.UserControlers
{
    class ClassLec
    {
        public string Name { get; set; }
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public string Faculty { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Center { get; set; }
        [Required]
        public string Building { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Level { get; set; }
        [Required]
        public string Rank { get; set; }
        

    }
}
