using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Models
{
    public enum Grades
    {
        A = 6, 
        B = 5,
        C = 4,
        D = 3, 
        E = 2,
        F = 0
    }

    public class Grade
    {
        public int Id { get; set; }

        [Display(Name = "Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [Required]
        [Display(Name = "Select Grade")]
        public Grades SelectedGrade { get; set; }

        [Display(Name = "Subject's Grade")]
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
