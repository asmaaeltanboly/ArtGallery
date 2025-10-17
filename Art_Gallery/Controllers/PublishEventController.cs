using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Art_Gallery.Controllers
{
    public class PublishEventController : Controller
    {
        // GET: PublishEventController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PublishEventController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PublishEventController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PublishEventController/Create
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

        // GET: PublishEventController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PublishEventController/Edit/5
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

        // GET: PublishEventController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PublishEventController/Delete/5
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
