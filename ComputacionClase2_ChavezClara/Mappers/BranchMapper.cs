using AutoMapper;
using ComputacionClase2_ChavezClara.Dtos;
using ComputacionClase2_ChavezClara.Model;

namespace ComputacionClase2_ChavezClara.Mappers
{
    internal class BranchMapper : Profile
    {
        public BranchMapper()
        {
            CreateMap<Branch,BranchDto>();
            CreateMap<SaveBranchDto,Branch>();
        }
    }
}
