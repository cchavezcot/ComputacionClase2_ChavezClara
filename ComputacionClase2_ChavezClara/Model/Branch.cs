namespace ComputacionClase2_ChavezClara.Model
{
    public class Branch
    {
        public int Id { get; set; }

        public string? BranchName { get; set; }

        public string? ManagerName { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Commentary { get; set; }

        //foreigns
        public virtual ICollection<Inventory>? Inventories { get; set; }
    }
}
