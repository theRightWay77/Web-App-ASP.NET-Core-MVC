using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StartController : Controller
    {
        // GET: PartOfDayController
        public string Hello()
        {
            DateTime time = DateTime.Now;
            if (time.Hour < 6) return "Доброй ночи";
            if (time.Hour < 12) return "Доброе утро";
            if (time.Hour < 18) return "Добрый день";
            else return "Добрый вечер";
        }


        // GET: PartOfDayController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PartOfDayController/Create
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

        // GET: PartOfDayController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PartOfDayController/Edit/5
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

        // GET: PartOfDayController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PartOfDayController/Delete/5
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
