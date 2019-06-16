using Library;
using Library.Commands.Abstractions;
using Library.Domain.Entities;
using Library.Helper;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace Commands.CustomerCommands
{
    public class AddCustomerCMD : BaseCustomerCommand
    {
        public AddCustomerCMD(CustomerVM CustomerVM) : base(CustomerVM) { }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == CustomerVM.StateCustomer)
            {
                try
                {
                    if (CustomerVM.CurrentCustomer.Id == 0)
                    {
                        new CustomMessageBox().Show("Customer Added!");
                    }
                    else
                    {
                        new CustomMessageBox().Show("Customer Updated!");
                    }

                    App.UnitOfWork.Customers.Add(CustomerVM.CurrentCustomer);
                }
                catch (Exception)
                {
                    new CustomMessageBox().Show("Error!");
                }
                CustomerVM.CurrentCustomer = new Customer();
                CustomerVM.Customers = new ObservableCollection<Customer>(App.UnitOfWork.Customers.GetAll());
                CustomerVM.StateCustomer = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            CustomerVM.StateCustomer = value;
        }
    }
}
