using Library.Entities;
using Library.ViewModels;
using System;
using System.Linq;
using System.Windows;

namespace Commands.CustomerCommands
{
    public class AddCustomerCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public AddCustomerCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == LibraryVM.StateCustomer)
            {
                if (LibraryVM.btnAddCustomer.Content.ToString() == "Add")
                {
                    try
                    {
                        var No = LibraryVM.Customers.Count + 1;
                        LibraryVM.Customers.Add(new Customer(No, LibraryVM.CurrentCustomer.Name, LibraryVM.CurrentCustomer.Surname,
                            LibraryVM.CurrentCustomer.PhoneNumber, LibraryVM.CurrentCustomer.JoinedDate, LibraryVM.CurrentCustomer.Note));
                        LibraryVM.CurrentCustomer = new Customer();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fill all fields", "Error occured while adding Customer!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    foreach (var book in LibraryVM.Customers)
                    {
                        if (book.No == LibraryVM.CurrentCustomer.No)
                        {
                            book.Name = LibraryVM.CurrentCustomer.Name;
                            book.Surname = LibraryVM.CurrentCustomer.Surname;
                            book.PhoneNumber = LibraryVM.CurrentCustomer.PhoneNumber;
                            book.JoinedDate = LibraryVM.CurrentCustomer.JoinedDate;
                            book.Note = LibraryVM.CurrentCustomer.Note;
                            LibraryVM.CurrentCustomer = new Customer();
                            LibraryVM.btnAddCustomer.Content = "Add";
                            LibraryVM.StateCustomer = 0;
                            return;
                        }
                    }
                }
                LibraryVM.StateCustomer = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateCustomer = value;
        }
    }
}
