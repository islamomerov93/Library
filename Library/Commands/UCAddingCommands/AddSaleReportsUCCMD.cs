using Commands;
using Library.ViewModels;
using Library.Views.UserControls;

namespace Library.Commands.UCAddingCommands
{
    public class AddSaleReportsUCCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public AddSaleReportsUCCMD(LibraryVM libraryVM)
        {
            LibraryVM = libraryVM;
        }

        public override void Execute(object parameter)
        {
            LibraryVM.Grid.Children.Add(new SalesReportsUC());
        }
    }
}
