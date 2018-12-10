using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BooksWebsite.Models
{
    public class BooksWebsiteContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BooksWebsiteContext() : base("name=BooksWebsiteContext")
        {
        }

        public System.Data.Entity.DbSet<BooksWebsite.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<BooksWebsite.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<BooksWebsite.Models.Writer> Writers { get; set; }
    }
}
