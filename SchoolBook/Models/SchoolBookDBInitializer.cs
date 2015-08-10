using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SchoolBook.Models
{
    public class SchoolBookDBInitializer : DropCreateDatabaseAlways<SchoolBookDB>
    {
        protected override void Seed(SchoolBookDB context)
        {

            //if (!context.Roles.Any(r => r.Name == "Admin"))
            //{
            //    var store = new RoleStore<IdentityRole>(context);
            //    var manager = new RoleManager<IdentityRole>(store);
            //    var role = new IdentityRole { Name = "Admin" };

            //    manager.Create(role);
            //}

            //if (!context.Roles.Any(r => r.Name == "Principle"))
            //{
            //    var store = new RoleStore<IdentityRole>(context);
            //    var manager = new RoleManager<IdentityRole>(store);
            //    var role = new IdentityRole { Name = "Principle" };

            //    manager.Create(role);
            //}

            //if (!context.Users.Any(u => u.UserName == "dotnetgeorge"))
            //{
            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    var user = new ApplicationUser { UserName = "dotnetgeorge" };

            //    manager.Create(user, "NOkian97mini!");
            //    manager.AddToRole(user.Id, "Admin");
            //}

            //if (!context.Users.Any(u => u.UserName == "petkoff.joro"))
            //{
            //    var store = new UserStore<ApplicationUser>(context);
            //    var manager = new UserManager<ApplicationUser>(store);
            //    var user = new ApplicationUser { UserName = "petkoff.joro" };

            //    manager.Create(user, "NOkian97mini!");
            //    manager.AddToRole(user.Id, "Principle");
            //}

            //context.Schools.Add(new School());


            //context.Teachers.Add(new Teacher());


            //context.Students.Add(new Student());


            //context.Classes.Add(new Class());


            //context.Grades.Add(new Grade());


            //context.Subjects.Add(new Subject());


            base.Seed(context);
        }
    }
}
