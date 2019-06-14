using Library.Commands.Abstractions;
using Library.ViewModels;
using System;

namespace Commands.CustomerCommands
{
    public class AddCustomerCMD : BaseCustomerCommand
    {
        public AddCustomerCMD(CustomerVM CustomerVM) : base(CustomerVM) { }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == CustomerVM.StateCustomer)
            {
                if (CustomerVM.btnAddCustomer.Content.ToString() == "Add")
                {
                    //try
                    //{
                    //    var No = CustomerVM.Customers.Count + 1;
                    //    CustomerVM.Customers.Add(new Customer(No, CustomerVM.CurrentCustomer.Name, CustomerVM.CurrentCustomer.Surname,
                    //        CustomerVM.CurrentCustomer.PhoneNumber, CustomerVM.CurrentCustomer.JoinedDate, CustomerVM.CurrentCustomer.Note));
                    //    CustomerVM.CurrentCustomer = new Customer();
                    //}
                    //catch (Exception)
                    //{
                    //    MessageBox.Show("Fill all fields", "Error occured while adding Customer!", MessageBoxButton.OK, MessageBoxImage.Error);
                    //}
                }
                else
                {
                    //foreach (var book in CustomerVM.Customers)
                    //{
                    //    if (book.No == CustomerVM.CurrentCustomer.No)
                    //    {
                    //        book.Name = CustomerVM.CurrentCustomer.Name;
                    //        book.Surname = CustomerVM.CurrentCustomer.Surname;
                    //        book.PhoneNumber = CustomerVM.CurrentCustomer.PhoneNumber;
                    //        book.JoinedDate = CustomerVM.CurrentCustomer.JoinedDate;
                    //        book.Note = CustomerVM.CurrentCustomer.Note;
                    //        CustomerVM.CurrentCustomer = new Customer();
                    //        CustomerVM.btnAddCustomer.Content = "Add";
                    //        CustomerVM.StateCustomer = 0;
                    //        return;
                    //    }
                    //}
                }
                CustomerVM.StateCustomer = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            CustomerVM.StateCustomer = value;
        }
    }
}
