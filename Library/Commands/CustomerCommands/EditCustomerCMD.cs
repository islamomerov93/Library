using Library.ViewModels;
using System;

namespace Commands.CustomerCommands
{
    public class EditCustomerCMD : BaseCommand
    {
        LibraryVM LibraryVM;
        public EditCustomerCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == 2)
            {
                LibraryVM.StateCustomer = 1;
                LibraryVM.btnAddCustomer.Content = "Save";
                return;
            }
        }
    }
}
