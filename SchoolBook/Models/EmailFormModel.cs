using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SchoolBook.Models
{
    public class EmailFormModel
    {
        [Required]
        [Display(Name = "Your Name")]
        public string FromName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Your E-mail")]
        public string FromEmail { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Your Message")]
        public string Message { get; set; }
    }
}
