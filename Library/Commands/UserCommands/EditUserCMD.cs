using Library.Domain.Entities;
using Library.ViewModels;
using Library.Views.UserControls;
using System;

namespace Commands.UserCommands
{
    public class EditUserCMD : BaseCommand
    {
        UserVM UserVM;
        public EditUserCMD(UserVM UserVM)
        {
            this.UserVM = UserVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == 2)
            {
                UserVM.StateUser = 1;
                UserVM.btnAddUser.Content = "Save";
                return;
            }
        }
    }
}
