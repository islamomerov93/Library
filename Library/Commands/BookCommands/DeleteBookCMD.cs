using Library.Domain.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.BookCommands
{
    public class DeleteBookCMD : BaseCommand
    {
        BookVM BookVM;

        public DeleteBookCMD(BookVM BookVM)
        {
            this.BookVM = BookVM;
        }


        public override void Execute(object parameter)
        {
            int value = Convert.ToInt32(parameter);
            BookVM.StateBook = value;
            BookVM.Books.Remove(BookVM.Books.FirstOrDefault(x=>x.No == BookVM.CurrentBook.No));
            BookVM.MyFilteredBooks = new ObservableCollection<Book>(BookVM.Books);
            BookVM.CurrentBook = null;
        }
    }
}
