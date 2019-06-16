using Library.Commands.Abstractions;
using Library.ViewModels;
using System;

namespace Commands.BranchCommands
{
    public class EditBranchCMD : BaseBranchCommand
    {
        public EditBranchCMD(BranchVM BranchVM) : base(BranchVM) { }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == 2)
            {
                BranchVM.StateBranch = 1;
                BranchVM.btnAddBranch.Content = "Save";
                return;
            }
        }
    }
}
