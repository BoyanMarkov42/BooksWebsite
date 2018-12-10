using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BooksWebsite.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Genre")]
        [Required]
        [StringLength(100)]
        public string GenreName { get; set; }

        [Display(Name = "Discriptions")]
        [Required]
        [StringLength(100)]
        public string Discriptions { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}