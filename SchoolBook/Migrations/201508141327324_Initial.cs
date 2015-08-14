namespace SchoolBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Classes",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Class = c.String(nullable: false, maxLength: 6),
            //            TeacherId = c.Int(),
            //            SchoolId = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Teachers", t => t.TeacherId)
            //    .ForeignKey("dbo.Schools", t => t.SchoolId)
            //    .Index(t => t.TeacherId)
            //    .Index(t => t.SchoolId);
            
            //CreateTable(
            //    "dbo.Homework",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            SubjectId = c.Int(nullable: false),
            //            ClassesId = c.Int(nullable: false),
            //            StartDate = c.DateTime(nullable: false),
            //            EndDate = c.DateTime(nullable: false),
            //            HomeworkTask = c.String(nullable: false),
            //            HomeworkResources = c.String(),
            //            HomeworkExternalResources = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Classes", t => t.ClassesId, cascadeDelete: true)
            //    .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
            //    .Index(t => t.SubjectId)
            //    .Index(t => t.ClassesId);
            
            //CreateTable(
            //    "dbo.Subjects",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            SubjectName = c.String(nullable: false),
            //            SubjectHoursPerWeek = c.Double(nullable: false),
            //            Classes_Id = c.Int(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Classes", t => t.Classes_Id)
            //    .Index(t => t.Classes_Id);
            
            //CreateTable(
            //    "dbo.Teachers",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            TeacherName = c.String(nullable: false, maxLength: 100),
            //            SchoolId = c.Int(nullable: false),
            //            SubjectId = c.Int(nullable: false),
            //            User_Id = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
            //    .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
            //    .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
            //    .Index(t => t.SchoolId)
            //    .Index(t => t.SubjectId)
            //    .Index(t => t.User_Id);
            
            //CreateTable(
            //    "dbo.Schools",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            SchoolName = c.String(nullable: false, maxLength: 150),
            //            SchoolAddress = c.String(nullable: false),
            //            SchoolPhoneNumber = c.String(nullable: false),
            //            SchoolInfo = c.String(nullable: false),
            //            SchoolWebSite = c.String(),
            //            User_Id = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
            //    .Index(t => t.User_Id);
            
            //CreateTable(
            //    "dbo.Students",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            StudentName = c.String(nullable: false, maxLength: 100),
            //            StudentAge = c.Int(nullable: false),
            //            StudentGender = c.Int(nullable: false),
            //            StudentAddress = c.String(nullable: false),
            //            StudentPhoneNumber = c.String(nullable: false),
            //            StudentEmail = c.String(nullable: false),
            //            Details = c.String(nullable: false),
            //            ClassesId = c.Int(nullable: false),
            //            SchoolId = c.Int(nullable: false),
            //            User_Id = c.String(maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Classes", t => t.ClassesId, cascadeDelete: true)
            //    .ForeignKey("dbo.Schools", t => t.SchoolId, cascadeDelete: true)
            //    .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
            //    .Index(t => t.ClassesId)
            //    .Index(t => t.SchoolId)
            //    .Index(t => t.User_Id);
            
            //CreateTable(
            //    "dbo.Absences",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            StudentId = c.Int(nullable: false),
            //            StartDate = c.DateTime(nullable: false),
            //            EndDate = c.DateTime(nullable: false),
            //            Unexcused = c.Double(nullable: false),
            //            Excused = c.Double(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
            //    .Index(t => t.StudentId);
            
            //CreateTable(
            //    "dbo.Grades",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            StudentId = c.Int(nullable: false),
            //            SelectedGrade = c.Int(nullable: false),
            //            SubjectId = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
            //    .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
            //    .Index(t => t.StudentId)
            //    .Index(t => t.SubjectId);
            
            //CreateTable(
            //    "dbo.Remarks",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            StudentId = c.Int(nullable: false),
            //            Date = c.DateTime(nullable: false),
            //            Content = c.String(nullable: false),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
            //    .Index(t => t.StudentId);
            
            //CreateTable(
            //    "dbo.AspNetUsers",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Email = c.String(maxLength: 256),
            //            EmailConfirmed = c.Boolean(nullable: false),
            //            PasswordHash = c.String(),
            //            SecurityStamp = c.String(),
            //            PhoneNumber = c.String(),
            //            PhoneNumberConfirmed = c.Boolean(nullable: false),
            //            TwoFactorEnabled = c.Boolean(nullable: false),
            //            LockoutEndDateUtc = c.DateTime(),
            //            LockoutEnabled = c.Boolean(nullable: false),
            //            AccessFailedCount = c.Int(nullable: false),
            //            UserName = c.String(nullable: false, maxLength: 256),
            //            Discriminator = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            //CreateTable(
            //    "dbo.AspNetUserClaims",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            ClaimType = c.String(),
            //            ClaimValue = c.String(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId);
            
            //CreateTable(
            //    "dbo.AspNetUserLogins",
            //    c => new
            //        {
            //            LoginProvider = c.String(nullable: false, maxLength: 128),
            //            ProviderKey = c.String(nullable: false, maxLength: 128),
            //            UserId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId);
            
            //CreateTable(
            //    "dbo.AspNetUserRoles",
            //    c => new
            //        {
            //            UserId = c.String(nullable: false, maxLength: 128),
            //            RoleId = c.String(nullable: false, maxLength: 128),
            //        })
            //    .PrimaryKey(t => new { t.UserId, t.RoleId })
            //    .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
            //    .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
            //    .Index(t => t.UserId)
            //    .Index(t => t.RoleId);
            
            //CreateTable(
            //    "dbo.AspNetRoles",
            //    c => new
            //        {
            //            Id = c.String(nullable: false, maxLength: 128),
            //            Name = c.String(nullable: false, maxLength: 256),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            //DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            //DropForeignKey("dbo.Subjects", "Classes_Id", "dbo.Classes");
            //DropForeignKey("dbo.Teachers", "SubjectId", "dbo.Subjects");
            //DropForeignKey("dbo.Teachers", "SchoolId", "dbo.Schools");
            //DropForeignKey("dbo.Teachers", "User_Id", "dbo.AspNetUsers");
            //DropForeignKey("dbo.Students", "User_Id", "dbo.AspNetUsers");
            //DropForeignKey("dbo.Schools", "User_Id", "dbo.AspNetUsers");
            //DropForeignKey("dbo.Students", "SchoolId", "dbo.Schools");
            //DropForeignKey("dbo.Remarks", "StudentId", "dbo.Students");
            //DropForeignKey("dbo.Grades", "SubjectId", "dbo.Subjects");
            //DropForeignKey("dbo.Grades", "StudentId", "dbo.Students");
            //DropForeignKey("dbo.Students", "ClassesId", "dbo.Classes");
            //DropForeignKey("dbo.Absences", "StudentId", "dbo.Students");
            //DropForeignKey("dbo.Classes", "SchoolId", "dbo.Schools");
            //DropForeignKey("dbo.Classes", "TeacherId", "dbo.Teachers");
            //DropForeignKey("dbo.Homework", "SubjectId", "dbo.Subjects");
            //DropForeignKey("dbo.Homework", "ClassesId", "dbo.Classes");
            //DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            //DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            //DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            //DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            //DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            //DropIndex("dbo.AspNetUsers", "UserNameIndex");
            //DropIndex("dbo.Remarks", new[] { "StudentId" });
            //DropIndex("dbo.Grades", new[] { "SubjectId" });
            //DropIndex("dbo.Grades", new[] { "StudentId" });
            //DropIndex("dbo.Absences", new[] { "StudentId" });
            //DropIndex("dbo.Students", new[] { "User_Id" });
            //DropIndex("dbo.Students", new[] { "SchoolId" });
            //DropIndex("dbo.Students", new[] { "ClassesId" });
            //DropIndex("dbo.Schools", new[] { "User_Id" });
            //DropIndex("dbo.Teachers", new[] { "User_Id" });
            //DropIndex("dbo.Teachers", new[] { "SubjectId" });
            //DropIndex("dbo.Teachers", new[] { "SchoolId" });
            //DropIndex("dbo.Subjects", new[] { "Classes_Id" });
            //DropIndex("dbo.Homework", new[] { "ClassesId" });
            //DropIndex("dbo.Homework", new[] { "SubjectId" });
            //DropIndex("dbo.Classes", new[] { "SchoolId" });
            //DropIndex("dbo.Classes", new[] { "TeacherId" });
            //DropTable("dbo.AspNetRoles");
            //DropTable("dbo.AspNetUserRoles");
            //DropTable("dbo.AspNetUserLogins");
            //DropTable("dbo.AspNetUserClaims");
            //DropTable("dbo.AspNetUsers");
            //DropTable("dbo.Remarks");
            //DropTable("dbo.Grades");
            //DropTable("dbo.Absences");
            //DropTable("dbo.Students");
            //DropTable("dbo.Schools");
            //DropTable("dbo.Teachers");
            //DropTable("dbo.Subjects");
            //DropTable("dbo.Homework");
            //DropTable("dbo.Classes");
        }
    }
}
