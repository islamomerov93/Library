using Library.Commands.Abstractions;
using Library.Domain.Entities;
using Library.Helper;
using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Library.Commands.LoginCommands
{
    public class LogInCMD : BaseLogInCommand
    {
        public LogInCMD(LogInVM loginVM) : base(loginVM) { }

        public override void Execute(object parameter)
        {
            LogInVM.Users = new List<User>(App.UnitOfWork.Users.GetAll());
            try
            {
                LogInVM.Password = (parameter as PasswordBox).Password;
                if (De_En_Crypter.Decrypt(LogInVM.Users.Single(x => x.Username == LogInVM.Username).Password, "Encrypt") == LogInVM.Password)
                {
                    LogInVM.Logined = LogInVM.Users.Single(x => x.Username == LogInVM.Username);
                    foreach (var item in ((App)Application.Current).Windows)
                    {
                        (item as Window).Hide();
                    }
                    (new MainWindow()).Show(); 
                }
                else (new CustomMessageBox()).Show("Password is Incorrect!"); 
            }
            catch (Exception)
            {
                (new CustomMessageBox()).Show("Username Does Not Exists");
            } 
        }
    }
}
