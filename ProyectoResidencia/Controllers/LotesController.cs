using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoResidencia.Controllers
{
    public class LotesController : Controller
    {
        // GET: Lotes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Lotes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lotes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lotes/Create
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

        // GET: Lotes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lotes/Edit/5
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

        // GET: Lotes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lotes/Delete/5
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
