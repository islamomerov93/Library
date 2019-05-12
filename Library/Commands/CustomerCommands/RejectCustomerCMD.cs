using Library.ViewModels;
using System;

namespace Commands.CustomerCommands
{
    public class RejectCustomerCMD : BaseCommand
    {
        LibraryVM LibraryVM;
        public RejectCustomerCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == LibraryVM.StateBook)
            {
                LibraryVM.StateBook = 0;
                LibraryVM.CurrentBook = null;
                return;
            }
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateBook = value;
        }
    }
}
