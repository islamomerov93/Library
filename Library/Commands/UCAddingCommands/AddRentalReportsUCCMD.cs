using Commands;
using Library.ViewModels;
using Library.Views.UserControls;

namespace Library.Commands.UCAddingCommands
{
    public class AddRentalReportsUCCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public AddRentalReportsUCCMD(LibraryVM libraryVM)
        {
            LibraryVM = libraryVM;
        }

        public override void Execute(object parameter)
        {
            LibraryVM.Grid.Children.Add(new RentalReportsUC());
        }
    }
}
