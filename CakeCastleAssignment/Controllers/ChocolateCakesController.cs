﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CakeCastleAssignment.Models;

namespace CakeCastleAssignment.Controllers
{
    public class ChocolateCakesController : Controller
    {
        private CakeModels db = new CakeModels();

        // GET: ChocolateCakes
        public async Task<ActionResult> Index()
        {
            return View(await db.ChocolateCakes.ToListAsync());
        }

        // GET: ChocolateCakes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChocolateCake chocolateCake = await db.ChocolateCakes.FindAsync(id);
            if (chocolateCake == null)
            {
                return HttpNotFound();
            }
            return View(chocolateCake);
        }

        // GET: ChocolateCakes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChocolateCakes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CakeID,CakeName,CakesDesc,Rate")] ChocolateCake chocolateCake)
        {
            if (ModelState.IsValid)
            {
                db.ChocolateCakes.Add(chocolateCake);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(chocolateCake);
        }

        // GET: ChocolateCakes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChocolateCake chocolateCake = await db.ChocolateCakes.FindAsync(id);
            if (chocolateCake == null)
            {
                return HttpNotFound();
            }
            return View(chocolateCake);
        }

        // POST: ChocolateCakes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CakeID,CakeName,CakesDesc,Rate")] ChocolateCake chocolateCake)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chocolateCake).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(chocolateCake);
        }

        // GET: ChocolateCakes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChocolateCake chocolateCake = await db.ChocolateCakes.FindAsync(id);
            if (chocolateCake == null)
            {
                return HttpNotFound();
            }
            return View(chocolateCake);
        }

        // POST: ChocolateCakes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ChocolateCake chocolateCake = await db.ChocolateCakes.FindAsync(id);
            db.ChocolateCakes.Remove(chocolateCake);
            await db.SaveChangesAsync();
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
