using Library.Commands.Abstractions;
using Library.ViewModels;
using Library.Views.UserControls;
using System;
using System.Windows.Input;

namespace Library.Commands.UCAddingCommands
{
    public class AddBranchUCCMD : ICommand
    {
        LibraryVM LibraryVM;

        public AddBranchUCCMD(LibraryVM libraryVM)
        {
            LibraryVM = libraryVM;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            LibraryVM.Grid.Children.Add(new BranchUC());
        }
    }
}
