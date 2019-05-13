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
            if (Convert.ToInt32(parameter) == LibraryVM.StateCustomer)
            {
                LibraryVM.StateCustomer = 0;
                LibraryVM.CurrentCustomer = null;
                return;
            }
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateCustomer = value;
        }
    }
}
