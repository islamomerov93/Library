using Library;
using Library.Commands.Abstractions;
using Library.Domain.Entities;
using Library.Helper;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace Commands.BookCommands
{
    public class AddBookCMD : BaseBookCommand
    {
        public AddBookCMD(BookVM BookVM) : base(BookVM){}

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == BookVM.StateBook)
            {
                try
                {
                    if (BookVM.CurrentBook.Id == 0)
                    {
                        new CustomMessageBox().Show("Book Added!");
                    }
                    else
                    {
                        new CustomMessageBox().Show("Book Updated!");
                    }

                    App.UnitOfWork.Books.Add(BookVM.CurrentBook);
                }
                catch (Exception)
                {
                    new CustomMessageBox().Show("Error!");
                }
                BookVM.CurrentBook = new Book();
                BookVM.Books = new ObservableCollection<Book>(App.UnitOfWork.Books.GetAll());
                BookVM.StateBook = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            BookVM.StateBook = value;
        }
    }
}
