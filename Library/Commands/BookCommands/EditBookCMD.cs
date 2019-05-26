using Library.ViewModels;
using System;

namespace Commands.BookCommands
{
    public class EditBookCMD : BaseCommand
    {
        BookVM BookVM;
        public EditBookCMD(BookVM BookVM)
        {
            this.BookVM = BookVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == 2)
            {
                BookVM.StateBook = 1;
                BookVM.btnAddBook.Content = "Save";
                return;
            }
        }
    }
}
