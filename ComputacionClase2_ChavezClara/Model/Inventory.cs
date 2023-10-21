namespace ComputacionClase2_ChavezClara.Model
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Existence { get; set; } //Imagino es la cantidad de libros que hay
        public int BookId { get; set; }
        public int BranchId {  get; set; }

        // foreigns
        public virtual Book? Book { get; set; }
        public virtual Branch? Branch { get; set; }
    }
}
