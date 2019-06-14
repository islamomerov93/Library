using Library.Commands.Abstractions;
using Library.ViewModels;
using System;

namespace Commands.CustomerCommands
{
    public class EditCustomerCMD : BaseCustomerCommand
    {
        public EditCustomerCMD(CustomerVM CustomerVM) : base(CustomerVM) { }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == 2)
            {
                CustomerVM.StateCustomer = 1;
                CustomerVM.btnAddCustomer.Content = "Save";
                return;
            }
        }
    }
}
