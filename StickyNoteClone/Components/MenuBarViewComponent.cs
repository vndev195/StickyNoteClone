using Microsoft.AspNetCore.Mvc;
using StickyNoteClone.Models.Repositories;
using StickyNoteClone.Models;

namespace StickyNoteClone.Components
{
    public class MenuBarViewComponent : ViewComponent
    {
        private readonly INoteRepository noteRepository;
        public MenuBarViewComponent(INoteRepository repo)
        {
            noteRepository = repo;
        }
        public IViewComponentResult Invoke()
        {

            //return View(noteRepository.Notes());
            return View();
        }
    }
}
