using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SchoolBook.Models;

namespace SchoolBook.Controllers
{
    public class GradesController : Controller
    {
        private SchoolBookDB db = new SchoolBookDB();

        // GET: Grades
        public ActionResult Index()
        {
            var grades = db.Grades.Include(g => g.Student).Include(g => g.Subject);
            return View(grades.ToList());
        }

        // GET: Grades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grade grade = db.Grades.Find(id);
            if (grade == null)
            {
                return HttpNotFound();
            }
            return View(grade);
        }

        // GET: Grades/Create
        [Authorize(Roles = "Admin, Principle")]
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName");
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "SubjectName");
            return View();
        }

        // POST: Grades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Principle")]
        public ActionResult Create([Bind(Include = "Id,StudentId,SelectedGrade,SubjectId")] Grade grade)
        {
            if (ModelState.IsValid)
            {
                db.Grades.Add(grade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName", grade.StudentId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "SubjectName", grade.SubjectId);
            return View(grade);
        }

        // GET: Grades/Edit/5
        [Authorize(Roles = "Admin, Principle")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grade grade = db.Grades.Find(id);
            if (grade == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName", grade.StudentId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "SubjectName", grade.SubjectId);
            return View(grade);
        }

        // POST: Grades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Principle")]
        public ActionResult Edit([Bind(Include = "Id,StudentId,SelectedGrade,SubjectId")] Grade grade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName", grade.StudentId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "SubjectName", grade.SubjectId);
            return View(grade);
        }

        // GET: Grades/Delete/5
        [Authorize(Roles = "Admin, Principle")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grade grade = db.Grades.Find(id);
            if (grade == null)
            {
                return HttpNotFound();
            }
            return View(grade);
        }

        // POST: Grades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Principle")]
        public ActionResult DeleteConfirmed(int id)
        {
            Grade grade = db.Grades.Find(id);
            db.Grades.Remove(grade);
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
