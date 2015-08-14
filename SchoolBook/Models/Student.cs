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
    public enum Gender
    {
        Male = 1,
        Female = 2
    }

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
        [Display(Name = "Student Genger")]
        [EnumDataType(typeof(Gender))]
        public Gender StudentGender { get; set; }

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

        [Required]
        [Display(Name = "Parent Full Name")]
        public string ParentName { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Parent Address")]
        public string ParentAddress { get; set; }

        [ForeignKey("Classes")]
        [Display(Name = "Student's Class")]
        public int ClassesId { get; set; }
        public virtual Classes Classes { get; set; }

        [ForeignKey("School")]
        [Display(Name = "Student's School")]
        public int SchoolId { get; set; }
        public virtual School School { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Absence> Absences { get; set; }
        public virtual ICollection<Remark> Remarks { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
