namespace Library.Domain.Entities
{
    public class Permission
    {
        public bool CanAddBook { get; set; }
        public bool CanAddUser { get; set; }
        public bool CanAddBranch { get; set; }
        public bool CanAddCustomer { get; set; }
        public bool CanAddEmployee { get; set; }
        public bool CanRentSale { get; set; }
    }
}
