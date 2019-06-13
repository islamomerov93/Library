using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Domain.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public int No { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public Permission Permissions { get; set; }

        public User()
        {
        }

        public User(int id, int no, string username, int password, Permission permissions)
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
