using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BooksWebsite.Models
{
    public class Writer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [StringLength(200)]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(200)]
        public string LastName { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}