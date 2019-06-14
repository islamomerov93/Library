using Library.Commands.Abstractions;
using Library.ViewModels;
using System;

namespace Commands.BookCommands
{
    public class EditBookCMD : BaseBookCommand
    {
        public EditBookCMD(BookVM BookVM) : base(BookVM) { }

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
