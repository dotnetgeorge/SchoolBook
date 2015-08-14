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
    public class RemarksController : Controller
    {
        private SchoolBookDB db = new SchoolBookDB();

        // GET: Remarks
        public ActionResult Index()
        {
            var remarks = db.Remarks.Include(r => r.Student);
            return View(remarks.ToList());
        }

        // GET: Remarks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remark remark = db.Remarks.Find(id);
            if (remark == null)
            {
                return HttpNotFound();
            }
            return View(remark);
        }

        // GET: Remarks/Create
        public ActionResult Create()
        {
            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName");
            return View();
        }

        // POST: Remarks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentId,Date,Content")] Remark remark)
        {
            if (ModelState.IsValid)
            {
                db.Remarks.Add(remark);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName", remark.StudentId);
            return View(remark);
        }

        // GET: Remarks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remark remark = db.Remarks.Find(id);
            if (remark == null)
            {
                return HttpNotFound();
            }
            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName", remark.StudentId);
            return View(remark);
        }

        // POST: Remarks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentId,Date,Content")] Remark remark)
        {
            if (ModelState.IsValid)
            {
                db.Entry(remark).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.StudentId = new SelectList(db.Students, "Id", "StudentName", remark.StudentId);
            return View(remark);
        }

        // GET: Remarks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Remark remark = db.Remarks.Find(id);
            if (remark == null)
            {
                return HttpNotFound();
            }
            return View(remark);
        }

        // POST: Remarks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Remark remark = db.Remarks.Find(id);
            db.Remarks.Remove(remark);
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
