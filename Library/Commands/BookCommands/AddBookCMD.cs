using Library.Domain.Entities;
using Library.ViewModels;
using System;
using System.Windows;

namespace Commands.BookCommands
{
    public class AddBookCMD : BaseCommand
    {
        BookVM BookVM;

        public AddBookCMD(BookVM BookVM)
        {
            this.BookVM = BookVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == BookVM.StateBook)
            {
                if (BookVM.btnAddBook.Content.ToString() == "Add")
                {
                    try
                    {
                        var No = BookVM.Books.Count + 1;
                        BookVM.Books.Add(new Book(No, BookVM.CurrentBook.Title, BookVM.CurrentBook.AuthorName, BookVM.CurrentBook.PurchaseCost,
                        BookVM.CurrentBook.SaleCost, BookVM.CurrentBook.Quantity, BookVM.CurrentBook.Branch, BookVM.CurrentBook.Note));
                        BookVM.CurrentBook = new Book();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fill all fields", "Error occured while adding book!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    
                }
                else
                {
                    foreach (var book in BookVM.Books)
                    {
                        if (book.No == BookVM.CurrentBook.No)
                        {
                            book.Title = BookVM.CurrentBook.Title;
                            book.AuthorName = BookVM.CurrentBook.AuthorName;
                            book.PurchaseCost = BookVM.CurrentBook.PurchaseCost;
                            book.SaleCost = BookVM.CurrentBook.SaleCost;
                            book.Quantity = BookVM.CurrentBook.Quantity;
                            book.Branch = BookVM.CurrentBook.Branch;
                            book.Note = BookVM.CurrentBook.Note;
                            BookVM.CurrentBook = new Book();
                            BookVM.btnAddBook.Content = "Add";
                            BookVM.StateBook = 0;
                            return;
                        }
                    }
                }
                BookVM.StateBook = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            BookVM.StateBook = value;
        }
    }
}
