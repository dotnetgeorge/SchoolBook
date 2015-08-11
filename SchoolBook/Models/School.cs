using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Models
{
    public class School
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        [Display(Name = "School Name")]
        public string SchoolName { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "School Address")]
        public string SchoolAddress { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "School Phone Number")]
        public string SchoolPhoneNumber { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "School Information")]
        public string SchoolInfo { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "School Web Site")]
        public string SchoolWebSite { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Classes> Classes { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
