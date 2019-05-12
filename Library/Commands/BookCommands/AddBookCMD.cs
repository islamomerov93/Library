using Library.Entities;
using Library.ViewModels;
using System;
using System.Linq;
using System.Windows;

namespace Commands.BookCommands
{
    public class AddBookCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public AddBookCMD(LibraryVM LibraryVM)
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
                        var No = LibraryVM.Books.Count + 1;
                        LibraryVM.Books.Add(new Book(No, LibraryVM.CurrentBook.Title, LibraryVM.CurrentBook.AuthorName, LibraryVM.CurrentBook.PurchaseCost,
                        LibraryVM.CurrentBook.SaleCost, LibraryVM.CurrentBook.Quantity, LibraryVM.CurrentBook.Branch, LibraryVM.CurrentBook.Note));
                        LibraryVM.CurrentBook = new Book();
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
                            LibraryVM.CurrentBook = new Book();
                            LibraryVM.btnAddBook.Content = "Add";
                            LibraryVM.StateBook = 0;
                            return;
                        }
                    }
                }
                LibraryVM.StateBook = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateBook = value;
        }
    }
}
