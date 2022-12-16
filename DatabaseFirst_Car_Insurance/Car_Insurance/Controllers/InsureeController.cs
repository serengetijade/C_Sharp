using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Car_Insurance.Models;

namespace Car_Insurance.Controllers
{
    public class InsureeController : Controller
    {
        private db_InsuranceEntities db = new db_InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree);  //This method, defined below, defines the property value for "Quote"
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CalculateQuote(insuree); //Every time a insuree is edited, it will update the rateQuote.
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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


        public decimal CalculateQuote(Insuree insuree)
        {
            using (db_InsuranceEntities db = new db_InsuranceEntities())
            {
                decimal rateQuote = 50;
                //decimal age = new DateTime(DateTime.Now.Subtract(insuree.DateOfBirth).Ticks).Year-1;
                //TimeSpan age = (TimeSpan)(insuree.DateOfBirth - DateTime.Now);
                var age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (age <= 18) rateQuote += 100;
                else if (age >= 19 && age <= 25) rateQuote += 50;
                else rateQuote += 25;
                if (insuree.CarYear < 2000) rateQuote += 25;
                else if (insuree.CarYear > 2015) rateQuote += 25;
                if (insuree.CarMake == "Porsche") rateQuote += 25;
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera") rateQuote += 25;
                if (insuree.SpeedingTickets > 0) rateQuote += insuree.SpeedingTickets * 10;
                if (insuree.DUI) rateQuote = rateQuote * 1.25m;
                if (insuree.CoverageType) rateQuote = rateQuote * 1.50m;
                insuree.Quote = rateQuote;

                return insuree.Quote;
            }
        }

        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

    }
}
