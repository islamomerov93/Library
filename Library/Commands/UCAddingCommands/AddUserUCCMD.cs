using Commands;
using Library.ViewModels;
using Library.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Commands.UCAddingCommands
{
    public class AddUserUCCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public AddUserUCCMD(LibraryVM libraryVM)
        {
            LibraryVM = libraryVM;
        }

        public override void Execute(object parameter)
        {
            LibraryVM.Grid.Children.Add(new UserUC());
        }
    }
}
