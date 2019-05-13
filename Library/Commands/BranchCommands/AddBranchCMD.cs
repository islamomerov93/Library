using Commands;
using Library.Entities;
using Library.ViewModels;
using System;
using System.Linq;
using System.Windows;

namespace Commands.BranchCommands
{
    public class AddBranchCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public AddBranchCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == LibraryVM.StateBranch)
            {
                if (LibraryVM.btnAddBranch.Content.ToString() == "Add")
                {
                    try
                    {
                        var No = LibraryVM.Branches.Count + 1;
                        LibraryVM.Branches.Add(new Branch(No, LibraryVM.CurrentBranch.Name, LibraryVM.CurrentBranch.Address, LibraryVM.CurrentBranch.Note));
                        LibraryVM.CurrentBranch = new Branch();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fill all fields", "Error occured while adding Branch!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                else
                {
                    foreach (var branch in LibraryVM.Branches)
                    {
                        if (branch.No == LibraryVM.CurrentBranch.No)
                        {
                            branch.Name = LibraryVM.CurrentBranch.Name;
                            branch.Address = LibraryVM.CurrentBranch.Address;
                            branch.Note = LibraryVM.CurrentBranch.Note;
                            LibraryVM.CurrentBranch = new Branch();
                            LibraryVM.btnAddBranch.Content = "Add";
                            LibraryVM.StateBranch = 0;
                            return;
                        }
                    }
                }
                LibraryVM.StateBranch = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateBranch = value;
        }
    }
}
