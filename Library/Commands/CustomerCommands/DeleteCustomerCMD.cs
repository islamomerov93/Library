using Library;
using Library.Commands.Abstractions;
using Library.Domain.Entities;
using Library.Helper;
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
            try
            {
                App.UnitOfWork.Customers.Remove(CustomerVM.CurrentCustomer);
                (new CustomMessageBox()).Show("Deleted!");
                CustomerVM.Customers = new ObservableCollection<Customer>(App.UnitOfWork.Customers.GetAll());
                CustomerVM.CurrentCustomer = new Customer();
            }
            catch (Exception)
            {
                (new CustomMessageBox()).Show("Error!");
            }
        }
    }
}
