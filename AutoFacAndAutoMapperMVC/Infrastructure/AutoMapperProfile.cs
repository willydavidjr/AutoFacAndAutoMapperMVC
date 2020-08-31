using AutoFacAndAutoMapperMVC.Models;
using AutoMapper;

namespace AutoFacAndAutoMapperMVC.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Person, PersonViewModel>();

            CreateMap<PersonViewModel, Person>();
        }
    }
}