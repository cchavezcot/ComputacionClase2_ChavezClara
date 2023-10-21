using AutoMapper;
using ComputacionClase2_ChavezClara.Dtos;
using ComputacionClase2_ChavezClara.Model;

namespace ComputacionClase2_ChavezClara.Services
{
    public class BranchService : IBranchService
    {
        private readonly ModelDBContext _dbContext;

        private readonly IMapper _mapper;

        public BranchService(ModelDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public IList<BranchDto> Get()
        {
            var list = _dbContext.Branches.ToList();
            return _mapper.Map<IList<BranchDto>>(list);
        }

        public void Save(SaveBranchDto dto)
        {
            var branch = _mapper.Map<Branch>(dto);
            _dbContext.Branches.Add(branch);
            _dbContext.SaveChanges();
        }

        public void Update(int id, SaveBranchDto dto)
        {
            var currentBranch = _dbContext.Branches.Find(id);
            if (currentBranch != null && currentBranch.Id == dto.Id)
            {
                _mapper.Map(dto, currentBranch);
                _dbContext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var currentBranch = _dbContext.Branches.Find(id);
            if (currentBranch != null)
            {
                _dbContext.Remove(currentBranch);
                _dbContext.SaveChanges();
            }
        }
    }
    public interface IBranchService
    {
        IList<BranchDto> Get();

        void Save(SaveBranchDto dto);

        void Update(int id, SaveBranchDto dto);

        void Delete(int id);
    }
}
