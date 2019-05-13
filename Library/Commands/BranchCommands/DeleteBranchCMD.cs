using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.BranchCommands
{
    public class DeleteBranchCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public DeleteBranchCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateBranch = value;
            LibraryVM.Branches.Remove(LibraryVM.Branches.FirstOrDefault(x => x.No == LibraryVM.CurrentBranch.No));
            LibraryVM.MyFilteredBranches = new ObservableCollection<Branch>(LibraryVM.Branches);
            LibraryVM.CurrentBranch = null;
        }
    }
}
