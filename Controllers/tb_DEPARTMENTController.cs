using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    public class tb_DEPARTMENTController : Controller
    {
        private Manage db = new Manage();

        // GET: tb_DEPARTMENT
        public ActionResult Index()
        {
            return View(db.tb_DEPARTMENT.ToList());
        }

        // GET: tb_DEPARTMENT/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_DEPARTMENT tb_DEPARTMENT = db.tb_DEPARTMENT.Find(id);
            if (tb_DEPARTMENT == null)
            {
                return HttpNotFound();
            }
            return View(tb_DEPARTMENT);
        }

        // GET: tb_DEPARTMENT/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tb_DEPARTMENT/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DepartmentID,DepartmentName")] tb_DEPARTMENT tb_DEPARTMENT)
        {
            if (ModelState.IsValid)
            {
                db.tb_DEPARTMENT.Add(tb_DEPARTMENT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tb_DEPARTMENT);
        }

        // GET: tb_DEPARTMENT/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_DEPARTMENT tb_DEPARTMENT = db.tb_DEPARTMENT.Find(id);
            if (tb_DEPARTMENT == null)
            {
                return HttpNotFound();
            }
            return View(tb_DEPARTMENT);
        }

        // POST: tb_DEPARTMENT/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DepartmentID,DepartmentName")] tb_DEPARTMENT tb_DEPARTMENT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_DEPARTMENT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_DEPARTMENT);
        }

        // GET: tb_DEPARTMENT/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_DEPARTMENT tb_DEPARTMENT = db.tb_DEPARTMENT.Find(id);
            if (tb_DEPARTMENT == null)
            {
                return HttpNotFound();
            }
            return View(tb_DEPARTMENT);
        }

        // POST: tb_DEPARTMENT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_DEPARTMENT tb_DEPARTMENT = db.tb_DEPARTMENT.Find(id);
            db.tb_DEPARTMENT.Remove(tb_DEPARTMENT);
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
