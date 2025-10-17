using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Art_Gallery.Controllers
{
    public class SculptureController : Controller
    {
        // GET: SculptureController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SculptureController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SculptureController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SculptureController/Create
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

        // GET: SculptureController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SculptureController/Edit/5
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

        // GET: SculptureController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SculptureController/Delete/5
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
