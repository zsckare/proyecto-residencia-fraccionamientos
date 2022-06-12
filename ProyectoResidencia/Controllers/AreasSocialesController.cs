using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoResidencia.Controllers
{
    public class AreasSocialesController : Controller
    {
        // GET: AreasSociales
        public ActionResult Index()
        {
            return View();
        }

        // GET: AreasSociales/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AreasSociales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AreasSociales/Create
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

        // GET: AreasSociales/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AreasSociales/Edit/5
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

        // GET: AreasSociales/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AreasSociales/Delete/5
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
