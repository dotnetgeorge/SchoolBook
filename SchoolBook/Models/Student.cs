using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolBook.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required]
        [Range(6, 60)]
        [Display(Name = "Student Age")]
        public int StudentAge { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Student Address")]
        public string StudentAddress { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Student Phone Number")]
        public string StudentPhoneNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Student E-mail")]
        public string StudentEmail { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Student Details")]
        public string Details { get; set; }

        [ForeignKey("Classes")]
        [Display(Name = "Student's Class")]
        public int ClassesId { get; set; }
        public virtual Classes Classes { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int SchoolId { get; set; }
        public virtual School School { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
