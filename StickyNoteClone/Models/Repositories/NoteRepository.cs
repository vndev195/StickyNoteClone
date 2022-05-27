using AutoMapper;
using StickyNoteClone.Models.DTO;
namespace StickyNoteClone.Models.Repositories
{
    public class NoteRepository : INoteRepository
    {
        StickyNoteDbContext _context;
        private readonly IMapper _mapper;
        public NoteRepository(StickyNoteDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IEnumerable<NoteViewModel> Notes()
        {

            return _mapper.Map<IEnumerable<NoteViewModel>>(_context.Notes);
        }

        public IEnumerable<NoteViewModel> GetDisplayedNotes()
        {
            return _mapper.Map<IEnumerable<NoteViewModel>>(_context.Notes.Where(x => x.IsDisplayed == true));
            //return _context.Notes.Where(x => x.IsDisplayed == true);
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

        public void DeleteNote(Note note)
        {
            _context.Notes.Remove(note);
            _context.SaveChanges();
        }
    }
}
