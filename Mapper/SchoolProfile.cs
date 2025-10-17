using AutoMapper;
using WebMap.Models.Dto;
using WebMap.Models.Entities;

namespace WebMap.Mapper
{
    public class SchoolProfile:Profile
    {
        public SchoolProfile() 
        {
            CreateMap<SchooDto,  School>();
        }
    }
}
