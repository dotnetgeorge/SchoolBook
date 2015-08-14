namespace SchoolBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialStudent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "ParentName", c => c.String(nullable: false));
            AddColumn("dbo.Students", "ParentAddress", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "ParentAddress");
            DropColumn("dbo.Students", "ParentName");
        }
    }
}
