using AutoMapper;
using ComputacionClase2_ChavezClara.Dtos;
using ComputacionClase2_ChavezClara.Model;

namespace ComputacionClase2_ChavezClara.Mappers
{
    internal class EditorialMapper : Profile
    {
        public EditorialMapper()
        {
            CreateMap<Editorial, EditorialDto>();
            CreateMap<SaveEditorialDto, Editorial>();
        }
    }
}
