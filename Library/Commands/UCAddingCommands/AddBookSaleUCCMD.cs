using Library.Commands.Abstractions;
using Library.ViewModels;
using Library.Views.UserControls;

namespace Library.Commands.UCAddingCommands
{
    public class AddBookSaleUCCMD : BaseUCAddingCommand
    {
        public AddBookSaleUCCMD(LibraryVM libraryVM) : base(libraryVM) { }

        public override void Execute(object parameter)
        {
            LibraryVM.Grid.Children.Add(new BookSalesUC());
        }
    }
}
