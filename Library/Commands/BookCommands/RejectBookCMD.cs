using Library.ViewModels;
using System;

namespace Commands.BookCommands
{
    public class RejectBookCMD : BaseCommand
    {
        BookVM BookVM;
        public RejectBookCMD(BookVM BookVM)
        {
            this.BookVM = BookVM;
        }

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
