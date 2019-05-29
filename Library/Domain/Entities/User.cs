using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public Permissions Permissions { get; set; }

        public User()
        {
        }

        public User(int id, int no, string username, int password, Permissions permissions)
        {
            Username = username;
            Password = password;
            Permissions = permissions;
        }

        public User Clone()
        {
            return new User(Id,No,Username,Password,Permissions);
        }
    }
}
