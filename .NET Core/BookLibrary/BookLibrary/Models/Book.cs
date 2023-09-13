using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookLibrary.Models
{
    public class Book
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [DisplayName("Book Name")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter release date")]
        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;

        [Required]
        [DisplayName("Display Order")]
        [Range(1, int.MaxValue, ErrorMessage = "Display Order for category must be greater than 0")]
        public long DisplayOrder { get; set; }

        //[Required]
        //[EmailAddress]
        //[RegularExpression(@"[a-zA-Z0-9_\.+]+@(live|hotmail|gmail)(\.com|\.om)", ErrorMessage = "Must be live, hotmail or gmail")]
        //[MaxLength(50)]
        //public string? Email { get; set; }
    }
}
