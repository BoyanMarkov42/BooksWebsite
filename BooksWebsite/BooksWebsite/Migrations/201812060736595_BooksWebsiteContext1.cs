namespace BooksWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BooksWebsiteContext1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "Discriptions", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Genres", "Discriptions");
        }
    }
}
