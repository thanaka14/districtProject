using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using districtProject.Models;

namespace districtProject.Controllers
{
    public class MultipleDistrictsController : Controller
    {
        private testEntities db = new testEntities();

        // GET: MultipleDistricts
        public ActionResult Index()
        {
            return View(db.MultipleDistricts.ToList());
        }

        // GET: MultipleDistricts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultipleDistrict multipleDistrict = db.MultipleDistricts.Find(id);
            if (multipleDistrict == null)
            {
                return HttpNotFound();
            }
            return View(multipleDistrict);
        }

        // GET: MultipleDistricts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MultipleDistricts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "multiple_district_id,multiple_district_name_thai,multiple_district_name_eng")] MultipleDistrict multipleDistrict)
        {
            if (ModelState.IsValid)
            {
                db.MultipleDistricts.Add(multipleDistrict);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(multipleDistrict);
        }

        // GET: MultipleDistricts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultipleDistrict multipleDistrict = db.MultipleDistricts.Find(id);
            if (multipleDistrict == null)
            {
                return HttpNotFound();
            }
            return View(multipleDistrict);
        }

        // POST: MultipleDistricts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "multiple_district_id,multiple_district_name_thai,multiple_district_name_eng")] MultipleDistrict multipleDistrict)
        {
            if (ModelState.IsValid)
            {
                db.Entry(multipleDistrict).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(multipleDistrict);
        }

        // GET: MultipleDistricts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MultipleDistrict multipleDistrict = db.MultipleDistricts.Find(id);
            if (multipleDistrict == null)
            {
                return HttpNotFound();
            }
            return View(multipleDistrict);
        }

        // POST: MultipleDistricts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MultipleDistrict multipleDistrict = db.MultipleDistricts.Find(id);
            db.MultipleDistricts.Remove(multipleDistrict);
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
