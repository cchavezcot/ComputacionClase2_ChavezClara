using AutoMapper;
using ComputacionClase2_ChavezClara.Dtos;
using ComputacionClase2_ChavezClara.Model;
using Microsoft.EntityFrameworkCore;

namespace ComputacionClase2_ChavezClara.Services
{
    public class BookService : IBookService
    {
        private readonly ModelDBContext _dbContext;

        private readonly IMapper _mapper;

        public BookService(ModelDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IList<BookDto> Get()
        {
            var list = _dbContext.Books
                                .Include(p => p.Editorial)
                                .ToList();

            return _mapper.Map<IList<BookDto>>(list);
        }

        public void Save(SaveBookDto dto)
        {
            var book = _mapper.Map<Book>(dto); //Metodo Mapper global
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }

        public void Update(int id, SaveBookDto dto)
        {
            var currentBook = _dbContext.Books.Find(id);

            if (currentBook != null && currentBook.Id == dto.Id)
            {
                _mapper.Map(dto, currentBook); //Metodo mapper local
                _dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var currentBook = _dbContext.Books.Find(id);

            if (currentBook != null)
            {
                _dbContext.Remove(currentBook);
                _dbContext.SaveChanges();
            }
        }
    }

    public interface IBookService
    {
        IList<BookDto> Get();

        void Save(SaveBookDto dto);

        void Update(int id, SaveBookDto dto);

        void Delete(int id);
    }
}
