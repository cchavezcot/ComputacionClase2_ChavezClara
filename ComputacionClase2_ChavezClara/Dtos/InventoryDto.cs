using ComputacionClase2_ChavezClara.Model;

namespace ComputacionClase2_ChavezClara.Dtos
{
    public class InventoryDto
    {
        public int Id { get; set; }
        public int Existence { get; set; }
        public int BookId { get; set; }
        public int BranchId { get; set; }
        public virtual Book? Book { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}
