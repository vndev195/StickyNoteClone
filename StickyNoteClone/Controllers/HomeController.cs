using Microsoft.AspNetCore.Mvc;
using StickyNoteClone.Models;
using System.Diagnostics;
using StickyNoteClone.Models.Repositories;
namespace StickyNoteClone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private INoteRepository repo;
        public HomeController(ILogger<HomeController> logger, INoteRepository noteRepository)
        {
            _logger = logger;
            repo = noteRepository;
        }

        public IActionResult Index()
        {
            var data = RouteData?.Values["id"];
            Note note = repo.GetById(Convert.ToInt32(data));
            if (note != null)
            {
                note.IsDisplayed = true;
                repo.UpdateNote(note);
            }
            return View(repo.GetDisplayedNotes());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}