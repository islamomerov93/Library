using Library.Domain;
using Library.Domain.Abstractions;
using Library.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Library.DataAccess.EF_CodeFirst.Repositories
{
    public class BookRepository : IBookRepository
    {
        LibraryDBContext context;
        public List<Book> GetAll()
        {
            List<Book> books;
            using (context = new LibraryDBContext())
            {
                books = new List<Book>(context.Books.Include("Branch"));
            }
            return books;
        }

        public Book GetById(int id)
        {
            Book book;
            using (context = new LibraryDBContext())
            {
                book = context.Books.AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            return book;
        }

        public void Add(Book book)
        {
            using (context = new LibraryDBContext())
            {
                if (book.Id == 0)
                {
                    context.Books.Add(book);
                    context.SaveChanges();
                }
                else
                {
                    Book newBook = context.Books.FirstOrDefault(x => x.Id == book.Id);
                    newBook.Title = book.Title;
                    newBook.PurchaseCost = book.PurchaseCost;
                    newBook.Quantity = book.Quantity;
                    newBook.SaleCost = book.SaleCost;
                    newBook.AuthorName = book.AuthorName;
                    newBook.BranchId = book.Branch.Id;
                    context.Entry(newBook.Branch).State = System.Data.Entity.EntityState.Unchanged;
                    context.SaveChanges();
                }
            }
        }

        public void Remove(Book entity)
        {
            using (context = new LibraryDBContext())
            {
                Book book = context.Books.FirstOrDefault(x => x.Id == entity.Id);
                context.Books.Remove(book);
                context.SaveChanges();
            }
        }
    }
}
