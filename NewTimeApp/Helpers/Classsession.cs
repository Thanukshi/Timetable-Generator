using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTimeApp.Helpers
{
    class Classsession
    {
        public string Lecturer { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Subjectcode { get; set; }
        [Required]
        public string tag { get; set; }
        [Required]
        public string groupid { get; set; }
        [Required]
        public string count { get; set; }
        [Required]
        public string duration { get; set; }
    }
}
