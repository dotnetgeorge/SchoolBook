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
    public class HomeworksController : Controller
    {
        private SchoolBookDB db = new SchoolBookDB();

        // GET: Homeworks
        public ActionResult Index()
        {
            var homeworks = db.Homeworks.Include(h => h.Classes).Include(h => h.Subject);
            return View(homeworks.ToList());
        }

        // GET: Homeworks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Homework homework = db.Homeworks.Find(id);
            if (homework == null)
            {
                return HttpNotFound();
            }
            return View(homework);
        }

        // GET: Homeworks/Create
        public ActionResult Create()
        {
            ViewBag.ClassesId = new SelectList(db.Classes, "Id", "Class");
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "SubjectName");
            return View();
        }

        // POST: Homeworks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,SubjectId,ClassesId,StartDate,EndDate,HomeworkTask,HomeworkResources,HomeworkExternalResources")] Homework homework)
        {
            if (ModelState.IsValid)
            {
                db.Homeworks.Add(homework);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ClassesId = new SelectList(db.Classes, "Id", "Class", homework.ClassesId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "SubjectName", homework.SubjectId);
            return View(homework);
        }

        // GET: Homeworks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Homework homework = db.Homeworks.Find(id);
            if (homework == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClassesId = new SelectList(db.Classes, "Id", "Class", homework.ClassesId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "SubjectName", homework.SubjectId);
            return View(homework);
        }

        // POST: Homeworks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,SubjectId,ClassesId,StartDate,EndDate,HomeworkTask,HomeworkResources,HomeworkExternalResources")] Homework homework)
        {
            if (ModelState.IsValid)
            {
                db.Entry(homework).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ClassesId = new SelectList(db.Classes, "Id", "Class", homework.ClassesId);
            ViewBag.SubjectId = new SelectList(db.Subjects, "Id", "SubjectName", homework.SubjectId);
            return View(homework);
        }

        // GET: Homeworks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Homework homework = db.Homeworks.Find(id);
            if (homework == null)
            {
                return HttpNotFound();
            }
            return View(homework);
        }

        // POST: Homeworks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Homework homework = db.Homeworks.Find(id);
            db.Homeworks.Remove(homework);
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
