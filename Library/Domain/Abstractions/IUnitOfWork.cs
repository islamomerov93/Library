namespace Library.Domain.Abstractions
{
    public interface IUnitOfWork
    {
        IBookRepository Books { get; }
        IBranchRepository Branches { get; }
        ICustomerRepository Customers { get; }
        IUserRepository Users { get; }
        IEmployeeRepository Employees { get; }
        IBookStateRepository BookStates { get; }
    }
}
