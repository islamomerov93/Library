using Library.Commands.Abstractions;
using Library.ViewModels;
using Library.Views.UserControls;

namespace Library.Commands.UCAddingCommands
{
    public class AddSaleReportsUCCMD : BaseUCAddingCommand
    {
        public AddSaleReportsUCCMD(LibraryVM libraryVM) : base(libraryVM) { }

        public override void Execute(object parameter)
        {
            LibraryVM.Grid.Children.Add(new SalesReportsUC());
        }
    }
}
