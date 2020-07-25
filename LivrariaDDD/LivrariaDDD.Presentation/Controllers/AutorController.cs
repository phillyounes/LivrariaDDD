using LivrariaDDD.Application.Interfaces;
using LivrariaDDD.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaDDD.Presentation.Controllers
{
    public class AutorController : Controller
    {
        private readonly IAutorApp _autorApp;
        public AutorController(IAutorApp autorApp)
        {
            _autorApp = autorApp;
        }

        // GET: AutorController
        public ActionResult Index()
        {
            return View(_autorApp.ReadAll());
        }

        // GET: AutorController/Details/5
        public ActionResult Details(int id)
        {
            return View(_autorApp.Read(id));
        }

        // GET: AutorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AutorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AutorViewModel autorViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _autorApp.Create(autorViewModel);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View(autorViewModel);
            }
            return View(autorViewModel);
        }

        // GET: AutorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_autorApp.Read(id));
        }

        // POST: AutorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AutorViewModel autorViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _autorApp.Update(autorViewModel);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View(autorViewModel);
            }
            return View(autorViewModel);
        }

        // GET: AutorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_autorApp.Read(id));
        }

        // POST: AutorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, AutorViewModel autorViewModel)
        {
            try
            {
                _autorApp.Delete(autorViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(autorViewModel);
            }
        }
    }
}
