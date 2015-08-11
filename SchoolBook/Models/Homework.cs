using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Models
{
    public class Homework
    {
        public int Id { get; set; }

        [Display(Name = "Subject Homework")]
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }

        [Display(Name = "Class Homework")]
        public int ClassesId { get; set; }
        public virtual Classes Classes { get; set; }

        [Required]
        [Display(Name = "Homework Start Date")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "Homework End Date")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        [Required]
        [Display(Name = "Homework Task")]
        [DataType(DataType.MultilineText)]
        public string HomeworkTask { get; set; }

        [Display(Name = "Homework Resources")]
        [DataType(DataType.MultilineText)]
        public string HomeworkResources { get; set; }

        [Display(Name = "Homework External Recources")]
        [DataType(DataType.Url)]
        public string HomeworkExternalResources { get; set; }
    }
}
