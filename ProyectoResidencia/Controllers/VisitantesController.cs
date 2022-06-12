using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoResidencia.Controllers
{
    public class VisitantesController : Controller
    {
        // GET: Visitantes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Visitantes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Visitantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Visitantes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Visitantes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Visitantes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Visitantes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Visitantes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
