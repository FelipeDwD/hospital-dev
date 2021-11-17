using AutoMapper;
using Hospital.WebApi.Application.ViewModels;
using Hospital.WebApi.Domain.Models;

namespace Hospital.WebApi.Application.Config
{
    public class AutoMapperProfileConfig : Profile
    {
        public AutoMapperProfileConfig()
        {
            CreateMap<UserModel, UserViewModel>().ReverseMap();
            CreateMap<ContactModel, ContactViewModel>().ReverseMap();
        }
    }
}
