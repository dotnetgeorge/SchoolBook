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
    public class AbsencesController : Controller
    {
        private SchoolBookDB db = new SchoolBookDB();

        // GET: Absences
        public ActionResult Index()
        {
            var absences = db.Absences.Include(a => a.Student);
            return View(absences.ToList());
        }

        // GET: Absences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Absence absence = db.Absences.Find(id);
            if (absence == null)
            {
                return HttpNotFound();
            }
            return View(absence);
        }

        // GET: Absences/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName");
            return View();
        }

        // POST: Absences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentId,StartDate,EndDate,Unexcused,Excused")] Absence absence)
        {
            if (ModelState.IsValid)
            {
                db.Absences.Add(absence);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName", absence.StudentId);
            return View(absence);
        }

        // GET: Absences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Absence absence = db.Absences.Find(id);
            if (absence == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName", absence.StudentId);
            return View(absence);
        }

        // POST: Absences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentId,StartDate,EndDate,Unexcused,Excused")] Absence absence)
        {
            if (ModelState.IsValid)
            {
                db.Entry(absence).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName", absence.StudentId);
            return View(absence);
        }

        // GET: Absences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Absence absence = db.Absences.Find(id);
            if (absence == null)
            {
                return HttpNotFound();
            }
            return View(absence);
        }

        // POST: Absences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Absence absence = db.Absences.Find(id);
            db.Absences.Remove(absence);
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
