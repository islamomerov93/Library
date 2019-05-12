using Library.ViewModels;
using System;

namespace Commands.BookCommands
{
    public class EditBookCMD : BaseCommand
    {
        LibraryVM LibraryVM;
        public EditBookCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == 2)
            {
                LibraryVM.StateBook = 1;
                LibraryVM.btnAddBook.Content = "Save";
                return;
            }
        }
    }
}
