using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.BookCommands
{
    public class DeleteBookCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public DeleteBookCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateBook = value;
            LibraryVM.Books.Remove(LibraryVM.Books.FirstOrDefault(x=>x.No == LibraryVM.CurrentBook.No));
            LibraryVM.MyFilteredBooks = new ObservableCollection<Book>(LibraryVM.Books);
            LibraryVM.CurrentBook = null;
        }
    }
}
