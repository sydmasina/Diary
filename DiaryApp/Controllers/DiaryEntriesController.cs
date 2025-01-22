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
    }
}
