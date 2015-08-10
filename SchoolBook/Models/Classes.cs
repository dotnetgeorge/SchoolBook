using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolBook.Models
{
    public class Classes
    {
        public int Id { get; set; }

        [Required]
        [StringLength(6)]
        [Display(Name = "Class")]
        public string Class { get; set; }

        //[Required]
        //[StringLength(1)]
        //[Display(Name = "Class Indentifier")]
        //public string ClassIndentifier { get; set; }

        [ForeignKey("TeacherId")]
        [Display(Name = "Class's Main Teacher")]
        public virtual Teacher Teacher { get; set; }
        public int? TeacherId { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
