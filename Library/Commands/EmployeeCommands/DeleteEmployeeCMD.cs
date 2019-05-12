using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.EmployeeCommands
{
    public class DeleteEmployeeCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public DeleteEmployeeCMD(LibraryVM LibraryVM)
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
