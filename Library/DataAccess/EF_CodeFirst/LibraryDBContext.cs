using Library.Domain.Entities;
using Library.Models;
using System.Data.Entity;

namespace Library.Domain
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext()

            : base("name=Library")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LibraryDBContext, Configuration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<SoldBook> SoldBooks { get; set; }
        public virtual DbSet<RentedBook> RentedBooks { get; set; }
    }
}