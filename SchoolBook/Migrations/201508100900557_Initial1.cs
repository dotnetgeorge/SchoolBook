namespace SchoolBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Classes", "TeacherId", c => c.Int());
            CreateIndex("dbo.Classes", "TeacherId");
            AddForeignKey("dbo.Classes", "TeacherId", "dbo.Teachers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classes", "TeacherId", "dbo.Teachers");
            DropIndex("dbo.Classes", new[] { "TeacherId" });
            DropColumn("dbo.Classes", "TeacherId");
        }
    }
}
