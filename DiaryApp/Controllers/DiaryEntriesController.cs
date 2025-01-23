using DiaryApp.Constants;
using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public DiaryEntriesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<DiaryEntry> diaryEntryList = _dbContext.DiaryEntries.ToList();

            return View(diaryEntryList);
        }

        public IActionResult NewEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewEntry(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < DiaryEntryConstants.TitleMinLength)
            {
                ModelState.AddModelError("Title", "Title is too short.");
            }

            if (ModelState.IsValid)
            {
                _dbContext.DiaryEntries.Add(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        [HttpGet]
        public IActionResult EditEntry(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntry diaryEntry = _dbContext.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult EditEntry(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < DiaryEntryConstants.TitleMinLength)
            {
                ModelState.AddModelError("Title", "Title is too short.");
            }

            if (ModelState.IsValid)
            {
                _dbContext.DiaryEntries.Update(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        [HttpGet]
        public IActionResult DeleteEntry(int? id) 
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntry diaryEntry = _dbContext.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult DeleteEntry(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < DiaryEntryConstants.TitleMinLength)
            {
                ModelState.AddModelError("Title", "Title is too short.");
            }

            if (ModelState.IsValid)
            {
                _dbContext.DiaryEntries.Remove(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
