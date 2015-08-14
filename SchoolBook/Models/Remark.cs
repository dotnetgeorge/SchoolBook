using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Models
{
    public class Remark
    {
        public int Id { get; set; }

        [ForeignKey("Student")]
        [Display(Name = "Student")]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

        [Required]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Content")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}
