using Library;
using Library.Commands.Abstractions;
using Library.Domain.Entities;
using Library.Helper;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace Commands.BookCommands
{
    public class DeleteBookCMD : BaseBookCommand
    {

        public DeleteBookCMD(BookVM BookVM) : base(BookVM) {}


        public override void Execute(object parameter)
        {
            try
            {
                App.UnitOfWork.Books.Remove(BookVM.CurrentBook);
                (new CustomMessageBox()).Show("Deleted!");
                BookVM.Books = new ObservableCollection<Book>(App.UnitOfWork.Books.GetAll());
                BookVM.CurrentBook = new Book();
            }
            catch (Exception)
            {
                (new CustomMessageBox()).Show("Error!");
            }
        }
    }
}
