namespace Library.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        IBookRepository Books { get; }
        IBranchRepository Branches { get; }
        ICustomerRepository Customers { get; }
        IUserRepository Users { get; }
        IEmployeeRepository Employees { get; }
        ISoldBookRepository SoldBooks { get; }
        IRentedBookRepository RentedBooks { get; }
    }
}
