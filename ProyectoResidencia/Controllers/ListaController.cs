using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoResidencia.Controllers
{
    public class ListaController : Controller
    {
        // GET: ListaNegra
        public ActionResult Index()
        {
            return View();
        }

        // GET: ListaNegra/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ListaNegra/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ListaNegra/Create
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

        // GET: ListaNegra/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ListaNegra/Edit/5
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

        // GET: ListaNegra/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ListaNegra/Delete/5
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
