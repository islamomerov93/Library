using Library.Domain.Entities;
using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.UserCommands
{
    public class DeleteUserCMD : BaseCommand
    {
        UserVM UserVM;

        public DeleteUserCMD(UserVM UserVM)
        {
            this.UserVM = UserVM;
        }

        public override void Execute(object parameter)
        {
            int value = Convert.ToInt32(parameter);
            UserVM.StateUser = value;
            UserVM.Users.Remove(UserVM.Users.FirstOrDefault(x => x.No == UserVM.CurrentUser.No));
            UserVM.MyFilteredUsers = new ObservableCollection<User>(UserVM.Users);
            UserVM.CurrentUser = null;
        }
    }
}
