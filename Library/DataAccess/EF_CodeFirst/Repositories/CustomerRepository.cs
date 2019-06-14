using Library.Domain;
using Library.Domain.Abstractions;
using Library.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Library.DataAccess.EF_CodeFirst.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        LibraryDBContext context;

        public List<Customer> GetAll()
        {
            List<Customer> customers;
            using (context = new LibraryDBContext())
            {
                customers = new List<Customer>(context.Customers);
            }
            return customers;
        }

        public Customer GetById(int id)
        {
            Customer customer;
            using (context = new LibraryDBContext())
            {
                customer = context.Customers.AsQueryable().FirstOrDefault(x => x.Id == id).Clone();
            }
            return customer;
        }

        public void Add(Customer customer)
        {
            using (context = new LibraryDBContext())
            {
                if (customer.Id == 0)
                {
                    context.Customers.Add(customer);
                    context.SaveChanges();
                }
                else
                {
                    Customer newCustomer = context.Customers.FirstOrDefault(x => x.Id == customer.Id);
                    newCustomer.Name = customer.Name;
                    newCustomer.Surname = customer.Surname;
                    newCustomer.PhoneNumber = customer.PhoneNumber;
                    newCustomer.JoinedDate = customer.JoinedDate;
                    newCustomer.Note = customer.Note;
                    context.SaveChanges();
                }
            }
        }

        public void Remove(Customer customer)
        {
            using (context = new LibraryDBContext())
            {
                Customer newCustomer = context.Customers.FirstOrDefault(x => x.Id == customer.Id);
                context.Customers.Remove(newCustomer);
                context.SaveChanges();
            }
        }
    }
}
