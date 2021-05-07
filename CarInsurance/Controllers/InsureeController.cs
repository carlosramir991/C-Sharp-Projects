using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {

            if (ModelState.IsValid)
            {
                table.Quote = 50;
                int tickets = table.SpeedingTickets * 10;
                table.Quote += tickets;

                if (table.DateOfBirth >= DateTime.Now.AddYears(-18))
                {

                    table.Quote += 50;


                }
                if (table.DateOfBirth == DateTime.Now.AddYears(-19) || table.DateOfBirth == DateTime.Now.AddYears(-20) || table.DateOfBirth == DateTime.Now.AddYears(-21)|| table.DateOfBirth == DateTime.Now.AddYears(-22)|| table.DateOfBirth == DateTime.Now.AddYears(-23)|| table.DateOfBirth == DateTime.Now.AddYears(-24)|| table.DateOfBirth == DateTime.Now.AddYears(-25))
                {
                    table.Quote += 50;

                }
                if (table.DateOfBirth < DateTime.Now.AddYears(-25))
                {
                    table.Quote += 25;
                }
                if(table.CarYear < 2000)
                {
                    table.Quote += 25;
                }
                if(table.CarYear > 2015)
                {
                    table.Quote += 25;
                }
                if(table.CarMake == "Porsche")
                {
                    table.Quote += 25;
                }
                if(table.CarMake == "Porsche" && table.CarModel == "911 Carrera")
                {
                    table.Quote += 25;
                }
                if(table.DUI == true)
                {
                    double DUI = Convert.ToDouble(table.Quote) * .25;
                    table.Quote += Convert.ToInt32(DUI);
                }
                if(table.CoverageType = true)
                {
                    double coverage = Convert.ToDouble(table.Quote) * .50;
                    table.Quote += Convert.ToInt32(coverage);
                }


                
                


                

                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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
