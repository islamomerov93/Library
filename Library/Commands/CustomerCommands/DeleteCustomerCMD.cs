using Library.Commands.Abstractions;
using Library.Domain.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.CustomerCommands
{
    public class DeleteCustomerCMD : BaseCustomerCommand
    {
        public DeleteCustomerCMD(CustomerVM CustomerVM) : base(CustomerVM) { }

        public override void Execute(object parameter)
        {
            int value = Convert.ToInt32(parameter);
            CustomerVM.StateCustomer = value;
            CustomerVM.Customers.Remove(CustomerVM.Customers.FirstOrDefault(x => x.No == CustomerVM.CurrentCustomer.No));
            CustomerVM.MyFilteredCustomers = new ObservableCollection<Customer>(CustomerVM.Customers);
            CustomerVM.CurrentCustomer = null;
        }
    }
}
