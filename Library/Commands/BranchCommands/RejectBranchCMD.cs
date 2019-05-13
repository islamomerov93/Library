using Library.ViewModels;
using System;

namespace Commands.BranchCommands
{
    public class RejectBranchCMD : BaseCommand
    {
        LibraryVM LibraryVM;
        public RejectBranchCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == LibraryVM.StateBranch)
            {
                LibraryVM.StateBranch = 0;
                LibraryVM.CurrentBranch = null;
                return;
            }
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateBranch = value;
        }
    }
}
