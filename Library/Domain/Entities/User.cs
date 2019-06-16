using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Library.Domain.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public int No { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CanAddBook { get; set; }
        public bool CanAddUser { get; set; }
        public bool CanAddBranch { get; set; }
        public bool CanAddCustomer { get; set; }
        public bool CanAddEmployee { get; set; }
        public bool CanRentSale { get; set; }
        public bool IsAdmin
        {
            set
            {
                GetType()
          .GetProperties().Where(p => p.PropertyType == typeof(bool) && p.Name.ToLower().Contains("can"))
          .ToList().ForEach(x => x.SetValue(this, true, null));
            }
        }
        public User()
        {
        }

        public User(int no, string username, string password, bool canAddBook, bool canAddUser, bool canAddBranch, bool canAddCustomer, bool canAddEmployee, bool canRentSale)
        {
            No = no;
            Username = username;
            Password = password;
            CanAddBook = canAddBook;
            CanAddUser = canAddUser;
            CanAddBranch = canAddBranch;
            CanAddCustomer = canAddCustomer;
            CanAddEmployee = canAddEmployee;
            CanRentSale = canRentSale;
        }

        public User(int id, int no, string username, string password, bool canAddBook, bool canAddUser, bool canAddBranch, bool canAddCustomer, bool canAddEmployee, bool canRentSale)
        {
            Id = id;
            No = no;
            Username = username;
            Password = password;
            CanAddBook = canAddBook;
            CanAddUser = canAddUser;
            CanAddBranch = canAddBranch;
            CanAddCustomer = canAddCustomer;
            CanAddEmployee = canAddEmployee;
            CanRentSale = canRentSale;
        }

        public User(string username, string password, bool isAdmin)
        {
            Username = username;
            Password = password;
            IsAdmin = isAdmin;
        }

        public User Clone()
        {
            return new User(Id,No,Username,Password,CanAddBook, CanAddUser, CanAddBranch, CanAddCustomer, CanAddEmployee, CanRentSale);
        }
    }
}
