using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_dot_NET_Core_MVC_Course_dot_NET5.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Employee Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"[a-zA-Z0-9_\.+]+@(live|hotmail|gmail)(\.com|\.om)", ErrorMessage = "Must be live, hotmail or gmail")]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter date of birth")]
        [DisplayName("Employee DOB")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DOB { get; set; }
    }
}
