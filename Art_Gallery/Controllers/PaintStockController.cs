using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Art_Gallery.Controllers
{
    public class PaintStockController : Controller
    {
        // GET: PaintStockController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PaintStockController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PaintStockController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaintStockController/Create
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

        // GET: PaintStockController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PaintStockController/Edit/5
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

        // GET: PaintStockController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PaintStockController/Delete/5
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
