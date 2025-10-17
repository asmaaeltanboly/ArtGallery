﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Art_Gallery.Controllers
{
    public class PaintController : Controller
    {
        // GET: PaintController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PaintController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PaintController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaintController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PaintController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PaintController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PaintController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PaintController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
