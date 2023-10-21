using AutoMapper;
using ComputacionClase2_ChavezClara.Dtos;
using ComputacionClase2_ChavezClara.Model;

namespace ComputacionClase2_ChavezClara.Mappers
{
    internal class InventoryMapper : Profile
    {
        public InventoryMapper() 
        {
            CreateMap<Inventory,InventoryDto >();
            CreateMap<SaveInventoryDto, Inventory>();
        }
    }
}
