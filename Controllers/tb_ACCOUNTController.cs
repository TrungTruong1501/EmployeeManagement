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
    public class tb_ACCOUNTController : Controller
    {
        private Manage db = new Manage();

        // GET: tb_ACCOUNT
        public ActionResult Index()
        {
            var tb_ACCOUNT = db.tb_ACCOUNT.Include(t => t.tb_EMPLOYEE);
            return View(tb_ACCOUNT.ToList());
        }

        // GET: tb_ACCOUNT/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_ACCOUNT tb_ACCOUNT = db.tb_ACCOUNT.Find(id);
            if (tb_ACCOUNT == null)
            {
                return HttpNotFound();
            }
            return View(tb_ACCOUNT);
        }

        // GET: tb_ACCOUNT/Create
        public ActionResult Create()
        {
            ViewBag.EmployeeID = new SelectList(db.tb_EMPLOYEE, "EmployeeID", "FullName");
            return View();
        }

        // POST: tb_ACCOUNT/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccountID,Username,Password,Email,Role,EmployeeID")] tb_ACCOUNT tb_ACCOUNT)
        {
            if (ModelState.IsValid)
            {
                db.tb_ACCOUNT.Add(tb_ACCOUNT);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EmployeeID = new SelectList(db.tb_EMPLOYEE, "EmployeeID", "FullName", tb_ACCOUNT.EmployeeID);
            return View(tb_ACCOUNT);
        }

        // GET: tb_ACCOUNT/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_ACCOUNT tb_ACCOUNT = db.tb_ACCOUNT.Find(id);
            if (tb_ACCOUNT == null)
            {
                return HttpNotFound();
            }
            ViewBag.EmployeeID = new SelectList(db.tb_EMPLOYEE, "EmployeeID", "FullName", tb_ACCOUNT.EmployeeID);
            return View(tb_ACCOUNT);
        }

        // POST: tb_ACCOUNT/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccountID,Username,Password,Email,Role,EmployeeID")] tb_ACCOUNT tb_ACCOUNT)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tb_ACCOUNT).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EmployeeID = new SelectList(db.tb_EMPLOYEE, "EmployeeID", "FullName", tb_ACCOUNT.EmployeeID);
            return View(tb_ACCOUNT);
        }

        // GET: tb_ACCOUNT/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tb_ACCOUNT tb_ACCOUNT = db.tb_ACCOUNT.Find(id);
            if (tb_ACCOUNT == null)
            {
                return HttpNotFound();
            }
            return View(tb_ACCOUNT);
        }

        // POST: tb_ACCOUNT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tb_ACCOUNT tb_ACCOUNT = db.tb_ACCOUNT.Find(id);
            db.tb_ACCOUNT.Remove(tb_ACCOUNT);
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
