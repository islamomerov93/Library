using Library.Domain;
using Library.Domain.Abstractions;
using Library.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Library.DataAccess.EF_CodeFirst.Repositories
{
    public class UserRepository : IUserRepository
    {
        LibraryDBContext context;
        
        public List<User> GetAll()
        {
            List<User> users;
            using (context = new LibraryDBContext())
            {
                users = new List<User>(context.Users);
            }
            return users;
        }

        public User GetById(int id)
        {
            User user;
            using (context = new LibraryDBContext())
            {
                user = context.Users.AsQueryable().FirstOrDefault(x => x.Id == id);
            }
            return user;
        }

        public void Add(User user)
        {
            using (context = new LibraryDBContext())
            {
                if (user.Id == 0)
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                else
                {
                    User newUser = context.Users.FirstOrDefault(x => x.Id == user.Id);
                    newUser.Username = user.Username;
                    newUser.Password = user.Password;
                    newUser.CanAddBook = user.CanAddBook;
                    newUser.CanAddCustomer = user.CanAddCustomer;
                    newUser.CanAddEmployee = user.CanAddEmployee;
                    newUser.CanAddBranch = user.CanAddBranch;
                    newUser.CanAddUser = user.CanAddUser;
                    newUser.CanRentSale = user.CanRentSale;
                    context.SaveChanges();
                }
            }
        }

        public void Remove(User user)
        {
            using (context = new LibraryDBContext())
            {
                User newUser = context.Users.FirstOrDefault(x => x.Id == user.Id);
                context.Users.Remove(newUser);
                context.SaveChanges();
            }
        }
    }
}
