using StickyNoteClone.Models.DTO;
namespace StickyNoteClone.Models.Repositories
{
    public interface INoteRepository
    {
        public IEnumerable<NoteViewModel> Notes(string userId);
        public Note GetById(int id);
        public IEnumerable<NoteViewModel> GetDisplayedNotes(string userId);
        public void AddNote(Note note);
        public void UpdateNote(Note note);
        public void DeleteNote(Note note);
    }
}
