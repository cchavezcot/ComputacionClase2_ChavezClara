using AutoMapper;
using ComputacionClase2_ChavezClara.Dtos;
using ComputacionClase2_ChavezClara.Model;

namespace ComputacionClase2_ChavezClara.Mappers
{
    internal class BookMapper : Profile
    {
        public BookMapper()
        {
            CreateMap<Book, BookDto>();
            CreateMap<SaveBookDto, Book>();
        }
    }
}
