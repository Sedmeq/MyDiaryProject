using Microsoft.AspNetCore.Mvc;
using MySecondProject.Data;
using MySecondProject.Models;

namespace MySecondProject.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DiaryEntriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<DiaryEntry> entries = _context.DiaryEntries.ToList();


            return View(entries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            _context.DiaryEntries.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("Index" , "Home") ;
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _context.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            _context.DiaryEntries.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Delete (int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            DiaryEntry? diaryEntry = _context.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }


        [HttpPost]
        public IActionResult Delete (DiaryEntry obj)
        {
            _context.DiaryEntries.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
