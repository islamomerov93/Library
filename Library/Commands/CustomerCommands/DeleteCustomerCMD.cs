using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.CustomerCommands
{
    public class DeleteCustomerCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public DeleteCustomerCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateCustomer = value;
            LibraryVM.Customers.Remove(LibraryVM.Customers.FirstOrDefault(x => x.No == LibraryVM.CurrentCustomer.No));
            LibraryVM.MyFilteredCustomers = new ObservableCollection<Customer>(LibraryVM.Customers);
            LibraryVM.CurrentCustomer = null;
        }
    }
}
