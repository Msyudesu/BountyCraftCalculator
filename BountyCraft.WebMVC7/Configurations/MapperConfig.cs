using AutoMapper;
using BountyCraft.WebMVC7.Data;
using BountyCraft.WebMVC7.Models;

namespace BountyCraft.WebMVC7.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<BCProfile, ProfilesVM>().ReverseMap();
            CreateMap<Item, ItemsVM>().ReverseMap();
        }
    }
}