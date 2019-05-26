﻿using Library.ViewModels;
using System;

namespace Commands.CustomerCommands
{
    public class RejectCustomerCMD : BaseCommand
    {
        CustomerVM CustomerVM;
        public RejectCustomerCMD(CustomerVM CustomerVM)
        {
            this.CustomerVM = CustomerVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == CustomerVM.StateCustomer)
            {
                CustomerVM.StateCustomer = 0;
                CustomerVM.CurrentCustomer = null;
                return;
            }
            int value = Convert.ToInt32(parameter);
            CustomerVM.StateCustomer = value;
        }
    }
}
