using Library.DataAccess.EF_CodeFirst.Repositories;
using Library.Domain.Abstractions;

namespace Library.DataAccess.EF_CodeFirst
{
    public class UnitOfWork : IUnitOfWork
    {
        public IBookRepository Books => new BookRepository();
        public IBranchRepository Branches => new BranchRepository();
        public ICustomerRepository Customers => new CustomerRepository();
        public IUserRepository Users => new UserRepository();
        public IEmployeeRepository Employees => new EmployeeRepository();
        public ISoldBookRepository SoldBooks => new SoldBookRepository();
        public IRentedBookRepository RentedBooks => new RentedBookRepository();
    }
}
