using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Art_Gallery.Controllers
{
    public class ExchangeProductsController : Controller
    {
        // GET: ExchangeProductsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ExchangeProductsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExchangeProductsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExchangeProductsController/Create
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

        // GET: ExchangeProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExchangeProductsController/Edit/5
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

        // GET: ExchangeProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExchangeProductsController/Delete/5
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
