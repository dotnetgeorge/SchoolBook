using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SchoolBook.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }

        [Required]
        [Range(1, 40)]
        [Display(Name = "Subject Hours Per Week")]
        public double SubjectHoursPerWeek { get; set; }
        
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
