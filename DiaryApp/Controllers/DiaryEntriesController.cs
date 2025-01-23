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
            if (obj != null && obj.Title.Length < DiaryEntryConstants.TitleMinLength) {
                ModelState.AddModelError("Title", "Title is too short.");
            }

            if (ModelState.IsValid) {
                _dbContext.DiaryEntries.Add(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(obj);
        }
    }
}
