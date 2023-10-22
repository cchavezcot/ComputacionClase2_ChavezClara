namespace ComputacionClase2_ChavezClara.Model
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Existence { get; set; }
        public int BookId { get; set; }
        public int BranchId { get; set; }
        
        // foreigns
        public virtual Book? Book { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}
