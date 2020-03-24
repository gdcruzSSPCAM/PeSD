using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PeSD.Models;

namespace PeSD.Controllers
{
    public class TypeDisabilitiesController : Controller
    {
        private PeSDContext db = new PeSDContext();

        // GET: TypeDisabilities
        public ActionResult Index()
        {
            return View(db.TypeDisabilities.ToList());
        }

        // GET: TypeDisabilities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDisability typeDisability = db.TypeDisabilities.Find(id);
            if (typeDisability == null)
            {
                return HttpNotFound();
            }
            return View(typeDisability);
        }

        // GET: TypeDisabilities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TypeDisabilities/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TypeDisabilityId,TypeDisabilityName")] TypeDisability typeDisability)
        {
            if (ModelState.IsValid)
            {
                db.TypeDisabilities.Add(typeDisability);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeDisability);
        }

        // GET: TypeDisabilities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDisability typeDisability = db.TypeDisabilities.Find(id);
            if (typeDisability == null)
            {
                return HttpNotFound();
            }
            return View(typeDisability);
        }

        // POST: TypeDisabilities/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TypeDisabilityId,TypeDisabilityName")] TypeDisability typeDisability)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeDisability).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeDisability);
        }

        // GET: TypeDisabilities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeDisability typeDisability = db.TypeDisabilities.Find(id);
            if (typeDisability == null)
            {
                return HttpNotFound();
            }
            return View(typeDisability);
        }

        // POST: TypeDisabilities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeDisability typeDisability = db.TypeDisabilities.Find(id);
            db.TypeDisabilities.Remove(typeDisability);
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
