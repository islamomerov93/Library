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
            if (Convert.ToInt32(parameter) == LibraryVM.StateBook)
            {
                if (LibraryVM.btnAddBook.Content.ToString() == "Add")
                {
                    try
                    {
                        LibraryVM.Books.Add(new Book(LibraryVM.NoBook++, LibraryVM.CurrentBook.Title, LibraryVM.CurrentBook.AuthorName, LibraryVM.CurrentBook.PurchaseCost,
                        LibraryVM.CurrentBook.SaleCost, LibraryVM.CurrentBook.Quantity, LibraryVM.CurrentBook.Branch, LibraryVM.CurrentBook.Note));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fill all fields", "Error occured while adding book!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    
                }
                else
                {
                    foreach (var book in LibraryVM.Books)
                    {
                        if (book.No == LibraryVM.CurrentBook.No)
                        {
                            book.Title = LibraryVM.CurrentBook.Title;
                            book.AuthorName = LibraryVM.CurrentBook.AuthorName;
                            book.PurchaseCost = LibraryVM.CurrentBook.PurchaseCost;
                            book.SaleCost = LibraryVM.CurrentBook.SaleCost;
                            book.Quantity = LibraryVM.CurrentBook.Quantity;
                            book.Branch = LibraryVM.CurrentBook.Branch;
                            book.Note = LibraryVM.CurrentBook.Note;
                        }
                    }
                }
                LibraryVM.StateBranch = 0;
                return;
            }
            LibraryVM.CurrentBook.Clear();
            if (LibraryVM.CurrentBranch.No == 0) LibraryVM.btnAddBranch.Content = "Add";
            else LibraryVM.btnAddBranch.Content = "Save";
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateBranch = value;
        }
    }
}
