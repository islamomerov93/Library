using Library.Commands.LoginCommands;
using Library.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace Library.ViewModels
{
    public class LogInVM : BaseVM
    {
        List<User> users;
        public List<User> Users
        {
            get { return users; }
            set { users = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Users))); }
        }

        public LogInCMD logInCMD { get; set; }

        private User logined;

        public User Logined
        {
            get { return logined; }
            set { logined = value; App.CurrentUser = Logined; }
        }
        public LogInVM()
        {
            Users = App.UnitOfWork.Users.GetAll().ToList();
            logInCMD = new LogInCMD(this);
            Logined = new User();
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
