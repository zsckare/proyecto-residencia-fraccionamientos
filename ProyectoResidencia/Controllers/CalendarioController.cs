using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoResidencia.Controllers
{
    public class CalendarioController : Controller
    {
        // GET: Calendario
        public ActionResult Index()
        {
            return View();
        }

        // GET: Calendario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calendario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calendario/Create
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

        // GET: Calendario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Calendario/Edit/5
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

        // GET: Calendario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }


        // POST: Calendario/Delete/5
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
