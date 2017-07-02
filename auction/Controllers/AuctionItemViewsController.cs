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
    public class AuctionItemViewsController : Controller
    {
        private PrizeAuctionEntities db = new PrizeAuctionEntities();

        // GET: AuctionItemViews
        public ActionResult Index()
        {
            return View(db.AuctionItemViews.ToList());
        }

        // GET: AuctionItemViews/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuctionItemView auctionItemView = db.AuctionItemViews.Find(id);
            if (auctionItemView == null)
            {
                return HttpNotFound();
            }
            return View(auctionItemView);
        }

        // GET: AuctionItemViews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuctionItemViews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AuctionItemTypeName,AuctionDescription,AuctionName,AuctionActive,BidPersonId,BidAmount,BidderName,BidderMobilePhone,AuctionItemId,ItemTypeId,Name,Description,AuctionId,Auctioned,BidId")] AuctionItemView auctionItemView)
        {
            if (ModelState.IsValid)
            {
                db.AuctionItemViews.Add(auctionItemView);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(auctionItemView);
        }

        // GET: AuctionItemViews/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuctionItemView auctionItemView = db.AuctionItemViews.Find(id);
            if (auctionItemView == null)
            {
                return HttpNotFound();
            }
            return View(auctionItemView);
        }

        // POST: AuctionItemViews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AuctionItemTypeName,AuctionDescription,AuctionName,AuctionActive,BidPersonId,BidAmount,BidderName,BidderMobilePhone,AuctionItemId,ItemTypeId,Name,Description,AuctionId,Auctioned,BidId")] AuctionItemView auctionItemView)
        {
            if (ModelState.IsValid)
            {
                db.Entry(auctionItemView).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(auctionItemView);
        }

        // GET: AuctionItemViews/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuctionItemView auctionItemView = db.AuctionItemViews.Find(id);
            if (auctionItemView == null)
            {
                return HttpNotFound();
            }
            return View(auctionItemView);
        }

        // POST: AuctionItemViews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            AuctionItemView auctionItemView = db.AuctionItemViews.Find(id);
            db.AuctionItemViews.Remove(auctionItemView);
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
