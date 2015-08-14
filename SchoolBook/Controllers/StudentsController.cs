using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolBook.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SchoolBook.Controllers
{
    public class StudentsController : Controller
    {
        private SchoolBookDB db = new SchoolBookDB();

        // GET: Students
        public ActionResult Index()
        {
            var students = db.Students.Include(s => s.Classes).Include(s => s.School);
            return View(students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            ViewBag.ClassesId = new SelectList(db.Classes, "Id", "Class");
            ViewBag.SchoolId = new SelectList(db.Schools, "Id", "SchoolName");
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentName,StudentAge,StudentGender,StudentAddress,StudentPhoneNumber,StudentEmail,Details,ParentName,ParentAddress,ClassesId,SchoolId")] Student student)
        {
            if (ModelState.IsValid)
            {
                var passwordHash = new PasswordHasher();
                var password = passwordHash.HashPassword("CC22bb!");
                var email = student.StudentEmail;
                var userName = student.StudentName.Trim(new char[] { ' ' });

                db.Users.Add(new ApplicationUser
                {
                    UserName = email,
                    Email = email,
                    PasswordHash = password,
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = student.StudentPhoneNumber,
                    LockoutEnabled = true
                });

                db.SaveChanges();

                //if (!(db.Users.Any(u => u.Email == student.StudentEmail)))
                //{
                //    var userStore = new UserStore<ApplicationUser>(db);
                //    var userManager = new UserManager<ApplicationUser>(userStore);
                //    var userToInsert = new ApplicationUser
                //    {
                //        UserName = userName,
                //        Email = student.StudentEmail,
                //        PhoneNumber = student.StudentPhoneNumber
                //    };

                //    userManager.Create(userToInsert, "CC22bb!");

                //    db.SaveChanges();
                //}

                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClassesId = new SelectList(db.Classes, "Id", "Class", student.ClassesId);
            ViewBag.SchoolId = new SelectList(db.Schools, "Id", "SchoolName", student.SchoolId);
            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClassesId = new SelectList(db.Classes, "Id", "Class", student.ClassesId);
            ViewBag.SchoolId = new SelectList(db.Schools, "Id", "SchoolName", student.SchoolId);
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentName,StudentAge,StudentGender,StudentAddress,StudentPhoneNumber,StudentEmail,Details,ParentName,ParentAddress,ClassesId,SchoolId")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClassesId = new SelectList(db.Classes, "Id", "Class", student.ClassesId);
            ViewBag.SchoolId = new SelectList(db.Schools, "Id", "SchoolName", student.SchoolId);
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
