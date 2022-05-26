using AutoMapper;
using StickyNoteClone.Models.DTO;

namespace StickyNoteClone.Models.DTO
{
    public class NoteProfile : Profile
    {
        public NoteProfile()
        {
            //Source to Destination
            CreateMap<NoteViewModel, Note>();
            CreateMap<Note, NoteViewModel>();
        }
    }
}
