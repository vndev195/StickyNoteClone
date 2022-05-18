namespace StickyNoteClone.Models.Repositories
{
    public interface INoteRepository
    {
        public IEnumerable<Note> Notes();
        public Note GetById(int id);
        public IEnumerable<Note> GetDisplayedNotes();
        public void UpdateNote(Note note);
    }
}
