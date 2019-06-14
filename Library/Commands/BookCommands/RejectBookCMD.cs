using Library.Commands.Abstractions;
using Library.ViewModels;
using System;

namespace Commands.BookCommands
{
    public class RejectBookCMD : BaseBookCommand
    {
        BookVM BookVM;
        public RejectBookCMD(BookVM BookVM) : base(BookVM) { }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == BookVM.StateBook)
            {
                BookVM.StateBook = 0;
                BookVM.CurrentBook = null;
                return;
            }
            int value = Convert.ToInt32(parameter);
            BookVM.StateBook = value;
        }
    }
}
