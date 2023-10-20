using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PSIUWeb.Data.Interface;
using PSIUWeb.Models;

namespace PSIUWeb.Controllers
{
    public class ContentController : Controller
    {
        private IContentRepository ContentRepository;

        public ContentController(
            IContentRepository _ContentRepo
        )
        {
            ContentRepository = _ContentRepo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(
                ContentRepository.GetContents()
            );
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id <= 0 || id == null)
                return NotFound();

            Content? c =
                ContentRepository.GetContentById(id.Value);

            if (c == null)
                return NotFound();

            return View(c);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Content Content)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ContentRepository.Update(Content);
                    return View("Index", ContentRepository.GetContents());
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
                }
            }
            return View("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            Content? c = ContentRepository.GetContentById(id.Value);

            if (c == null)
                return NotFound();

            return View(c);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            if (id == null || id == 0)
                return NotFound();

            ContentRepository.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Insert(Content c)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ContentRepository.Create(c);
                    return View("Index", ContentRepository.GetContents());
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return View();
        }
    }
}
