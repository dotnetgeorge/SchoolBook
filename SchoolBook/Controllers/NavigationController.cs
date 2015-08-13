using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SchoolBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolBook.Controllers
{
    public class NavigationController : Controller
    {
        // GET: Navigation
        [ChildActionOnly]
        public ActionResult Menu()
        {
            ApplicationDbContext userscontext = new ApplicationDbContext();
            var userStore = new UserStore<ApplicationUser>(userscontext);
            var userManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<IdentityRole>(userscontext);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            if (User.Identity.IsAuthenticated)
            {

                if (userManager.IsInRole(this.User.Identity.GetUserId(), "Admin"))
                {
                    return PartialView("_AdminMenuView");
                }
                else if (userManager.IsInRole(this.User.Identity.GetUserId(), "Principal")) 
                {
                    return PartialView("_PrincipalenuView");
                }
                else
                {
                    return PartialView("_Student");
                }
            }

            return PartialView("_Empty");
        }
    }
}