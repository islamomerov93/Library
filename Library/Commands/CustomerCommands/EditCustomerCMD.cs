using Library.ViewModels;
using System;

namespace Commands.CustomerCommands
{
    public class EditCustomerCMD : BaseCommand
    {
        CustomerVM CustomerVM;
        public EditCustomerCMD(CustomerVM CustomerVM)
        {
            this.CustomerVM = CustomerVM;
        }

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
