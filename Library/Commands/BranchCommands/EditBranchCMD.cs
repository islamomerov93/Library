using Library.ViewModels;
using System;

namespace Commands.BranchCommands
{
    public class EditBranchCMD : BaseCommand
    {
        LibraryVM LibraryVM;
        public EditBranchCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == 2)
            {
                LibraryVM.StateBook = 1;
                return;
            }
        }
    }
}
