using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using auction.Models;

namespace auction.Controllers
{
    public class BankViewsController : Controller
    {
        private PrizeAuctionEntities db = new PrizeAuctionEntities();

        // GET: BankViews
        public ActionResult Index()
        {
            return View(db.BankViews.ToList());
        }

        // GET: BankViews/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankView bankView = db.BankViews.Find(id);
            if (bankView == null)
            {
                return HttpNotFound();
            }
            return View(bankView);
        }

        // GET: BankViews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BankViews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AuctionName,AuctionDescription,AuctionToName,AuctionToMobilePhone,BankId,PersonId,AuctionId,Bank")] BankView bankView)
        {
            if (ModelState.IsValid)
            {
                db.BankViews.Add(bankView);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bankView);
        }

        // GET: BankViews/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankView bankView = db.BankViews.Find(id);
            if (bankView == null)
            {
                return HttpNotFound();
            }
            return View(bankView);
        }

        // POST: BankViews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AuctionName,AuctionDescription,AuctionToName,AuctionToMobilePhone,BankId,PersonId,AuctionId,Bank")] BankView bankView)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bankView).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bankView);
        }

        // GET: BankViews/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankView bankView = db.BankViews.Find(id);
            if (bankView == null)
            {
                return HttpNotFound();
            }
            return View(bankView);
        }

        // POST: BankViews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BankView bankView = db.BankViews.Find(id);
            db.BankViews.Remove(bankView);
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
