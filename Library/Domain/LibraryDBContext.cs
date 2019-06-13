using Library.Domain.Entities;
using System.Data.Entity;

namespace Library.Domain
{
    public class LibraryDBContext : DbContext
    {
        public LibraryDBContext()

            : base("name=LibraryDBContext")
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
        public virtual DbSet<Permission> Permissions { get; set; }
    }
}