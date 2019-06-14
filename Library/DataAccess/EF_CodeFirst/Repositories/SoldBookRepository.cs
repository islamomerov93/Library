using Library.Domain;
using Library.Domain.Abstractions;
using Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace Library.DataAccess.EF_CodeFirst.Repositories
{
    public class SoldBookRepository : ISoldBookRepository
    {
        LibraryDBContext context;
        public List<SoldBook> GetAll()
        {
            List<SoldBook> soldBooks;
            using (context = new LibraryDBContext())
            {
                soldBooks = new List<SoldBook>(context.SoldBooks.Include("Book").Include("User").Include("Client"));
            }
            return soldBooks;
        }

        public SoldBook GetById(int id)
        {
            SoldBook book;
            using (context = new LibraryDBContext())
            {
                book = context.SoldBooks.AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            return book;
        }

        public void Add(SoldBook soldBook)
        {
            using (context = new LibraryDBContext())
            {
                context.SoldBooks.Add(soldBook);
                context.SaveChanges();
            }
        }

        public void Remove(SoldBook soldBook)
        {
            using (context = new LibraryDBContext())
            {
                SoldBook newSoldBook = context.SoldBooks.FirstOrDefault(x => x.Id == soldBook.Id);
                context.SoldBooks.Remove(newSoldBook);
                context.SaveChanges();
            }
        }
    }
}
