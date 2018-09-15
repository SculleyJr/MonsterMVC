using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonsterMVC.Data;
using MonsterMVC.Domain.Data;

namespace MonsterMVC.Controllers
{
    public class EncounterParamsController : Controller
    {
        private MonsterDbContext db = new MonsterDbContext();

        // GET: EncounterParams
        public ActionResult Index()
        {
            return View(db.EncounterParams.ToList());
        }

        // GET: EncounterParams/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EncounterParam encounterParam = db.EncounterParams.Find(id);
            if (encounterParam == null)
            {
                return HttpNotFound();
            }
            return View(encounterParam);
        }

        // GET: EncounterParams/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EncounterParams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,AverageLvl,NumberOfMonsters")] EncounterParam encounterParam)
        {
            if (ModelState.IsValid)
            {
                db.EncounterParams.Add(encounterParam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(encounterParam);
        }

        // GET: EncounterParams/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EncounterParam encounterParam = db.EncounterParams.Find(id);
            if (encounterParam == null)
            {
                return HttpNotFound();
            }
            return View(encounterParam);
        }

        // POST: EncounterParams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,AverageLvl,NumberOfMonsters")] EncounterParam encounterParam)
        {
            if (ModelState.IsValid)
            {
                db.Entry(encounterParam).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(encounterParam);
        }

        // GET: EncounterParams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EncounterParam encounterParam = db.EncounterParams.Find(id);
            if (encounterParam == null)
            {
                return HttpNotFound();
            }
            return View(encounterParam);
        }

        // POST: EncounterParams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EncounterParam encounterParam = db.EncounterParams.Find(id);
            db.EncounterParams.Remove(encounterParam);
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
