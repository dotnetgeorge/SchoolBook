using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Models
{
    public class Absence
    {
        public int Id { get; set; }

        [ForeignKey("Student")]
        [Display(Name = "Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [Required]
        [Display(Name = "From Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "To Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        [Range(0, 600)]
        [Display(Name = "Unexcused Absences")]
        public double Unexcused { get; set; }

        [Required]
        [Range(0, 600)]
        [Display(Name = "Excused Absences")]
        public double Excused { get; set; }
    }
}
