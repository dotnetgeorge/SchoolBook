namespace SchoolBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSchool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schools", "SchoolEmail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Schools", "SchoolEmail");
        }
    }
}
