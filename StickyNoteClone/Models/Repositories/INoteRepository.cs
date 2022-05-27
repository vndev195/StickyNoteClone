using StickyNoteClone.Models.DTO;
namespace StickyNoteClone.Models.Repositories
{
    public interface INoteRepository
    {
        public IEnumerable<NoteViewModel> Notes();
        public Note GetById(int id);
        public IEnumerable<NoteViewModel> GetDisplayedNotes();
        public void UpdateNote(Note note);
        public void DeleteNote(Note note);
    }
}
