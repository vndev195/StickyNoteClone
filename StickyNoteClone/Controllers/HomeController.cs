using Microsoft.AspNetCore.Mvc;
using StickyNoteClone.Models;
using System.Diagnostics;
using StickyNoteClone.Models.Repositories;
using AutoMapper;
using StickyNoteClone.Models.DTO;
namespace StickyNoteClone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private INoteRepository repo;
        private IMapper _mapper;
        public HomeController(ILogger<HomeController> logger, INoteRepository noteRepository, IMapper mapper)
        {
            _logger = logger;
            repo = noteRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            ViewData["Notes"] = repo.Notes();
            ViewData["DisplayedNotes"] = repo.GetDisplayedNotes();
            return View();
        }

        [HttpPost]
        public IActionResult Index(NoteViewModel model)
        {
            Note note = _mapper.Map<Note>(model);
            Note findNote = repo.GetById(note.Id);
            if (findNote != null)
            {
                findNote.Title = note.Title;
                findNote.Content = note.Content;
                findNote.Color = note.Color;
                repo.UpdateNote(findNote);
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ChangeVisibility(int id, bool isDisplayed)
        {
            Note findNote = repo.GetById(id);
            if (findNote != null)
            {
                if (isDisplayed == false)
                {
                    findNote.IsDisplayed = true;
                    repo.UpdateNote(findNote);
                }
                else if(isDisplayed == true)
                {
                    findNote.IsDisplayed = false;
                    repo.UpdateNote(findNote);
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DeleteNote(int id)
        {
            Note findNote = repo.GetById(id);
            if (findNote != null)
            {
                repo.DeleteNote(findNote);
            }
            return RedirectToAction(nameof(Index));
        }
        // public IActionResult AddNewNote()
        // {

        // }
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