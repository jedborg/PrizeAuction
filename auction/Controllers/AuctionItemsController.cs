﻿using System;
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
    public class AuctionItemsController : Controller
    {
        private PrizeAuctionEntities db = new PrizeAuctionEntities();

        // GET: AuctionItems
        public ActionResult Index()
        {
            var auctionItems = db.AuctionItems.Include(a => a.Auction).Include(a => a.AuctionItemType).Include(a => a.Bid);
            return View(auctionItems.ToList());
        }

        // GET: AuctionItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuctionItem auctionItem = db.AuctionItems.Find(id);
            if (auctionItem == null)
            {
                return HttpNotFound();
            }
            return View(auctionItem);
        }

        // GET: AuctionItems/Create
        public ActionResult Create()
        {
            ViewBag.AuctionId = new SelectList(db.Auctions, "AuctionId", "Name");
            ViewBag.ItemTypeId = new SelectList(db.AuctionItemTypes, "ItemTypeId", "Name");
            ViewBag.BidId = new SelectList(db.Bids, "BidId", "BidId");
            return View();
        }

        // POST: AuctionItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AuctionItemId,ItemTypeId,Name,Description,AuctionId")] AuctionItem auctionItem)
        {
            if (ModelState.IsValid)
            {
                auctionItem.Auctioned = false;
                db.AuctionItems.Add(auctionItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AuctionId = new SelectList(db.Auctions, "AuctionId", "Name", auctionItem.AuctionId);
            ViewBag.ItemTypeId = new SelectList(db.AuctionItemTypes, "ItemTypeId", "Name", auctionItem.ItemTypeId);
            ViewBag.BidId = new SelectList(db.Bids, "BidId", "BidId", auctionItem.BidId);
            return View(auctionItem);
        }

        // GET: AuctionItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuctionItem auctionItem = db.AuctionItems.Find(id);
            if (auctionItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuctionId = new SelectList(db.Auctions, "AuctionId", "Name", auctionItem.AuctionId);
            ViewBag.ItemTypeId = new SelectList(db.AuctionItemTypes, "ItemTypeId", "Name", auctionItem.ItemTypeId);
            ViewBag.BidId = new SelectList(db.Bids, "BidId", "BidId", auctionItem.BidId);
            return View(auctionItem);
        }

        // POST: AuctionItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AuctionItemId,ItemTypeId,Name,Description,AuctionId,Auctioned,BidId")] AuctionItem auctionItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(auctionItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AuctionId = new SelectList(db.Auctions, "AuctionId", "Name", auctionItem.AuctionId);
            ViewBag.ItemTypeId = new SelectList(db.AuctionItemTypes, "ItemTypeId", "Name", auctionItem.ItemTypeId);
            ViewBag.BidId = new SelectList(db.Bids, "BidId", "BidId", auctionItem.BidId);
            return View(auctionItem);
        }

        // GET: AuctionItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AuctionItem auctionItem = db.AuctionItems.Find(id);
            if (auctionItem == null)
            {
                return HttpNotFound();
            }
            return View(auctionItem);
        }

        // POST: AuctionItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AuctionItem auctionItem = db.AuctionItems.Find(id);
            db.AuctionItems.Remove(auctionItem);
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
