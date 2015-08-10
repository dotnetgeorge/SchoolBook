namespace SchoolBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClassNumber = c.Int(nullable: false),
                        ClassIndentifier = c.String(nullable: false, maxLength: 1),
                        Teacher_Id = c.Int(),
                        School_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teachers", t => t.Teacher_Id)
                .ForeignKey("dbo.Schools", t => t.School_Id)
                .Index(t => t.Teacher_Id)
                .Index(t => t.School_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false, maxLength: 100),
                        StudentAge = c.Int(nullable: false),
                        StudentAddress = c.String(nullable: false),
                        StudentPhoneNumber = c.String(nullable: false),
                        Details = c.String(nullable: false),
                        ClassesId = c.Int(nullable: false),
                        School_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassesId, cascadeDelete: true)
                .ForeignKey("dbo.Schools", t => t.School_Id)
                .Index(t => t.ClassesId)
                .Index(t => t.School_Id);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SelectedGrade = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.SubjectId)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(nullable: false),
                        SubjectHoursPerWeek = c.Double(nullable: false),
                        Classes_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.Classes_Id)
                .Index(t => t.Classes_Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TeacherName = c.String(nullable: false, maxLength: 100),
                        SchoolId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SchoolId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SchoolName = c.String(nullable: false, maxLength: 150),
                        SchoolAddress = c.String(nullable: false),
                        SchoolPhoneNumber = c.String(nullable: false),
                        SchoolInfo = c.String(nullable: false),
                        SchoolWebSite = c.String(),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Subjects", "Classes_Id", "dbo.Classes");
            DropForeignKey("dbo.Grades", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.Grades", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Teachers", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Teachers", "SchoolId", "dbo.Schools");
            DropForeignKey("dbo.Students", "School_Id", "dbo.Schools");
            DropForeignKey("dbo.Classes", "School_Id", "dbo.Schools");
            DropForeignKey("dbo.Classes", "Teacher_Id", "dbo.Teachers");
            DropForeignKey("dbo.Students", "ClassesId", "dbo.Classes");
            DropIndex("dbo.Teachers", new[] { "SubjectId" });
            DropIndex("dbo.Teachers", new[] { "SchoolId" });
            DropIndex("dbo.Subjects", new[] { "Classes_Id" });
            DropIndex("dbo.Grades", new[] { "Student_Id" });
            DropIndex("dbo.Grades", new[] { "SubjectId" });
            DropIndex("dbo.Students", new[] { "School_Id" });
            DropIndex("dbo.Students", new[] { "ClassesId" });
            DropIndex("dbo.Classes", new[] { "School_Id" });
            DropIndex("dbo.Classes", new[] { "Teacher_Id" });
            DropTable("dbo.Schools");
            DropTable("dbo.Teachers");
            DropTable("dbo.Subjects");
            DropTable("dbo.Grades");
            DropTable("dbo.Students");
            DropTable("dbo.Classes");
        }
    }
}
