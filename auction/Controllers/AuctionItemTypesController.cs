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
    public class AuctionItemTypesController : Controller
    {
        private PrizeAuctionEntities db = new PrizeAuctionEntities();

        // GET: AuctionItemTypes
        public ActionResult Index()
        {
            return View(db.AuctionItemTypes.ToList());
        }

        // GET: AuctionItemTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuctionItemType auctionItemType = db.AuctionItemTypes.Find(id);
            if (auctionItemType == null)
            {
                return HttpNotFound();
            }
            return View(auctionItemType);
        }

        // GET: AuctionItemTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuctionItemTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ItemTypeId,Name")] AuctionItemType auctionItemType)
        {
            if (ModelState.IsValid)
            {
                db.AuctionItemTypes.Add(auctionItemType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auctionItemType);
        }

        // GET: AuctionItemTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuctionItemType auctionItemType = db.AuctionItemTypes.Find(id);
            if (auctionItemType == null)
            {
                return HttpNotFound();
            }
            return View(auctionItemType);
        }

        // POST: AuctionItemTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ItemTypeId,Name")] AuctionItemType auctionItemType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(auctionItemType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auctionItemType);
        }

        // GET: AuctionItemTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuctionItemType auctionItemType = db.AuctionItemTypes.Find(id);
            if (auctionItemType == null)
            {
                return HttpNotFound();
            }
            return View(auctionItemType);
        }

        // POST: AuctionItemTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AuctionItemType auctionItemType = db.AuctionItemTypes.Find(id);
            db.AuctionItemTypes.Remove(auctionItemType);
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
