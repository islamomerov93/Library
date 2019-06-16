using Library.Domain;
using Library.Domain.Abstractions;
using Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace Library.DataAccess.EF_CodeFirst.Repositories
{
    public class RentedBookRepository : IRentedBookRepository
    {
        LibraryDBContext context;
        public List<RentedBook> GetAll()
        {
            List<RentedBook> soldBooks;
            using (context = new LibraryDBContext())
            {
                soldBooks = new List<RentedBook>(context.RentedBooks.Include("Book").Include("User").Include("Client"));
            }
            return soldBooks;
        }

        public RentedBook GetById(int id)
        {
            RentedBook book;
            using (context = new LibraryDBContext())
            {
                book = context.RentedBooks.AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            return book;
        }

        public void Add(RentedBook rentedBook)
        {
            using (context = new LibraryDBContext())
            {
                context.RentedBooks.Add(rentedBook);
                context.SaveChanges();
            }
        }

        public void Remove(RentedBook rentedBook)
        {
            using (context = new LibraryDBContext())
            {
                RentedBook newRentedBook = context.RentedBooks.FirstOrDefault(x => x.Id == rentedBook.Id);
                context.RentedBooks.Remove(newRentedBook);
                context.SaveChanges();
            }
        }
    }
}
