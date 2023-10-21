using ComputacionClase2_ChavezClara.Model;

namespace ComputacionClase2_ChavezClara.Dtos
{
    public class SaveInventoryDto
    {
        public int? Id { get; set; }
        public int Existence { get; set; }
        public int BookId { get; set; }
        public int BranchId { get; set; }
    }
}
