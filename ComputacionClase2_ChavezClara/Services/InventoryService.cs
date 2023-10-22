using AutoMapper;
using ComputacionClase2_ChavezClara.Model;
using ComputacionClase2_ChavezClara.Dtos;
using Microsoft.EntityFrameworkCore;
using FluentValidation;

namespace ComputacionClase2_ChavezClara.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly ModelDBContext _dbContext;

        private readonly IMapper _mapper;

        private readonly IValidator<SaveInventoryDto> _validator;

        public InventoryService(ModelDBContext dbContext, IMapper mapper, IValidator<SaveInventoryDto> validator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _validator = validator;
        }

        public IList<InventoryDto> Get() 
        {
            var list = _dbContext.Inventories
                                .Include(x => x.Branch)
                                .Include(x => x.Book)
                                .Include(x => x.Book.Editorial)
                                .ToList();

            return _mapper.Map<IList<InventoryDto>>(list);
        }

        public void Save(SaveInventoryDto dto)
        {
            _validator.ValidateAndThrow(dto);

            var inventory = _mapper.Map<Inventory>(dto);
            _dbContext.Inventories.Add(inventory);
            _dbContext.SaveChanges();
        }

        public void Update(int id, SaveInventoryDto dto)
        {
            _validator.ValidateAndThrow(dto);

            var currentInventory = _dbContext.Inventories.Find(id);

            if (currentInventory != null && currentInventory.Id ==  dto.Id)
            {
                _mapper.Map(dto, currentInventory);
                _dbContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var currentInventory = _dbContext.Inventories.Find(id);

            if (currentInventory != null)
            {
                _dbContext.Remove(currentInventory);
                _dbContext.SaveChanges();
            }
        }
    }

    public interface IInventoryService
    {
        IList<InventoryDto>Get();

        void Save(SaveInventoryDto dto);

        void Update(int id, SaveInventoryDto dto);

        void Delete(int id);
    }
}
