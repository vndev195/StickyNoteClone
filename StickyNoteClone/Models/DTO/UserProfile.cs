using AutoMapper;

namespace StickyNoteClone.Models.DTO
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            //Source to Destination
            CreateMap<UserRegistrationModel, User>().
                ForMember(u=>u.UserName, opt => opt.MapFrom(x=>x.Email));
        }
    }
}
