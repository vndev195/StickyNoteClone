namespace StickyNoteClone.Models.Repositories
{
    public class NoteRepository : INoteRepository
    {
        StickyNoteDbContext _context;
        public NoteRepository(StickyNoteDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Note> Notes()
        {
            return _context.Notes;
        }

        public IEnumerable<Note> GetDisplayedNotes()
        {
            return _context.Notes.Where(x => x.IsDisplayed == true);
        }

        public void UpdateNote(Note note)
        {
            _context.Notes.Update(note);
            _context.SaveChanges();
        }

        public Note GetById(int id)
        {
            return _context.Notes.Find(id);
        }
    }
}
