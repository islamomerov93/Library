using Library;
using Library.Commands.Abstractions;
using Library.Domain.Entities;
using Library.Helper;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.UserCommands
{
    public class AddUserCMD : BaseUserCommand
    {
        public AddUserCMD(UserVM UserVM) : base(UserVM) { }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == UserVM.StateUser)
            {
                try
                {
                    if (UserVM.CurrentUser.Id == 0)
                    {
                        if (App.UnitOfWork.Users.GetAll().AsQueryable().FirstOrDefault(x => x.Username == UserVM.CurrentUser.Username) != null)
                        {
                            (new CustomMessageBox()).Show("This Username Already Taken!");
                            return;
                        }
                        UserVM.CurrentUser.Password = De_En_Crypter.Encrypt(UserVM.PasswordBox.ToString(), "Encrypt");
                        App.UnitOfWork.Users.Add(UserVM.CurrentUser);
                        (new CustomMessageBox()).Show("User Added!");
                    }
                    else if (UserVM.CurrentUser.Id > 0)
                    {
                        App.UnitOfWork.Users.Add(UserVM.CurrentUser);
                        (new CustomMessageBox()).Show("User Updated!");
                    }
                    UserVM.CurrentUser = new User();
                }
                catch (Exception)
                {
                    (new CustomMessageBox()).Show("Error!");
                }
                UserVM.CurrentUser = new User();
                UserVM.Users = new ObservableCollection<User>(App.UnitOfWork.Users.GetAll());
                UserVM.StateUser = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            UserVM.StateUser = value;
        }
    }
}
