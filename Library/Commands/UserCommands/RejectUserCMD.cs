using Library.ViewModels;
using System;

namespace Commands.UserCommands
{
    public class RejectUserCMD : BaseCommand
    {
        UserVM UserVM;
        public RejectUserCMD(UserVM UserVM)
        {
            this.UserVM = UserVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == UserVM.StateUser)
            {
                UserVM.StateUser = 0;
                UserVM.CurrentUser = null;
                return;
            }
            int value = Convert.ToInt32(parameter);
            UserVM.StateUser = value;
        }
    }
}
