using LivrariaDDD.Application.Interfaces;
using LivrariaDDD.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaDDD.Presentation.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroApp _livroApp;

        public LivroController(ILivroApp livroApp)
        {
            _livroApp = livroApp;
        }

        // GET: LivroController
        public ActionResult Index()
        {
            return View(_livroApp.ReadAll());
        }

        // GET: LivroController/Details/5
        public ActionResult Details(int id)
        {
            return View(_livroApp.Read(id));
        }

        // GET: LivroController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LivroController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LivroViewModel livroViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _livroApp.Create(livroViewModel);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View(livroViewModel);
            }
            return View(livroViewModel);
        }

        // GET: LivroController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_livroApp.Read(id));
        }

        // POST: LivroController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, LivroViewModel livroViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _livroApp.Update(livroViewModel);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                return View(livroViewModel);
            }
            return View(livroViewModel);
        }

        // GET: LivroController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_livroApp.Read(id));
        }

        // POST: LivroController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, LivroViewModel livroViewModel)
        {
            try
            {
                _livroApp.Delete(livroViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(livroViewModel);
            }
        }
    }
}
