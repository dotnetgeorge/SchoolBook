using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolBook.Models
{
    //[DisplayColumn("Id", "Id", false)]
    public class Teacher
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Teache Name")]
        [StringLength(100)]
        public string TeacherName { get; set; }
        
        [Display(Name = "Teacher's School")]
        public int SchoolId { get; set; }
        public virtual School School { get; set; }

        [Display(Name = "Teacher's Subject")]
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }

        public virtual ICollection<Classes> Classes { get; set; }
    }
}
