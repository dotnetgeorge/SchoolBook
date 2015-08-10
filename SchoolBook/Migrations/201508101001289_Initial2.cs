namespace SchoolBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classes", "Class", c => c.String(nullable: false, maxLength: 6));
            DropColumn("dbo.Classes", "ClassNumber");
            DropColumn("dbo.Classes", "ClassIndentifier");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Classes", "ClassIndentifier", c => c.String(nullable: false, maxLength: 1));
            AddColumn("dbo.Classes", "ClassNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Classes", "Class");
        }
    }
}
