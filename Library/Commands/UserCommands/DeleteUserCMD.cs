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
    public class DeleteUserCMD : BaseUserCommand
    {
        public DeleteUserCMD(UserVM UserVM) : base(UserVM) { }

        public override void Execute(object parameter)
        {
            try
            {
                App.UnitOfWork.Users.Remove(UserVM.CurrentUser);
                (new CustomMessageBox()).Show("Deleted!");
            }

            catch (Exception)
            {
                (new CustomMessageBox()).Show("Error!");
            }
            UserVM.CurrentUser = new User();
            UserVM.Users = new System.Collections.ObjectModel.ObservableCollection<User>(App.UnitOfWork.Users.GetAll());
        }
    }
}
