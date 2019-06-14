using Library.Commands.Abstractions;
using Library.ViewModels;
using System;

namespace Commands.BranchCommands
{
    public class RejectBranchCMD : BaseBranchCommand
    {
        public RejectBranchCMD(BranchVM BranchVM) : base(BranchVM) { }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == BranchVM.StateBranch)
            {
                BranchVM.StateBranch = 0;
                BranchVM.CurrentBranch = null;
                return;
            }
            int value = Convert.ToInt32(parameter);
            BranchVM.StateBranch = value;
        }
    }
}
