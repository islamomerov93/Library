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
        BranchVM BranchVM;

        public AddBranchCMD(BranchVM BranchVM)
        {
            this.BranchVM = BranchVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == BranchVM.StateBranch)
            {
                if (BranchVM.btnAddBranch.Content.ToString() == "Add")
                {
                    try
                    {
                        var No = BranchVM.Branches.Count + 1;
                        BranchVM.Branches.Add(new Branch(No, BranchVM.CurrentBranch.Name, BranchVM.CurrentBranch.Address, BranchVM.CurrentBranch.Note));
                        BranchVM.CurrentBranch = new Branch();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fill all fields", "Error occured while adding Branch!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                else
                {
                    foreach (var branch in BranchVM.Branches)
                    {
                        if (branch.No == BranchVM.CurrentBranch.No)
                        {
                            branch.Name = BranchVM.CurrentBranch.Name;
                            branch.Address = BranchVM.CurrentBranch.Address;
                            branch.Note = BranchVM.CurrentBranch.Note;
                            BranchVM.CurrentBranch = new Branch();
                            BranchVM.btnAddBranch.Content = "Add";
                            BranchVM.StateBranch = 0;
                            return;
                        }
                    }
                }
                BranchVM.StateBranch = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            BranchVM.StateBranch = value;
        }
    }
}
