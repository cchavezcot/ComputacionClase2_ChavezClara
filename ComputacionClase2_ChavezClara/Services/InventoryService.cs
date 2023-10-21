using AutoMapper;
using ComputacionClase2_ChavezClara.Model;
using ComputacionClase2_ChavezClara.Dtos;
using Microsoft.EntityFrameworkCore;

namespace ComputacionClase2_ChavezClara.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly ModelDBContext _dbContext;

        private readonly IMapper _mapper;

        public InventoryService(ModelDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IList<InventoryDto> Get() 
        {
            var list = _dbContext.Inventories
                                .Include(p => p.Book)
                                .Include(q => q.Branch)
                                .ToList();

            return _mapper.Map<IList<InventoryDto>>(list);
        }

        public void Save(SaveInventoryDto dto)
        {
            var inventory = _mapper.Map<Inventory>(dto);
            _dbContext.Inventories.Add(inventory);
            _dbContext.SaveChanges();
        }

        public void Update(int id, SaveInventoryDto dto)
        {
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
