using Library;
using Library.Commands.Abstractions;
using Library.Domain.Entities;
using Library.Helper;
using Library.ViewModels;
using System;
using System.Windows;

namespace Commands.BranchCommands
{
    public class AddBranchCMD : BaseBranchCommand
    {
        public AddBranchCMD(BranchVM BranchVM) : base(BranchVM) { }

        public override void Execute(object parameter)
        {
            
                try
                {
                    App.UnitOfWork.Branches.Add(BranchVM.CurrentBranch);
                    (new CustomMessageBox()).Show("Branch Added!");
                }
                catch (Exception)
                {
                    new CustomMessageBox().Show("Not Added");
                }
                BranchVM.StateBranch = 0;
                return;
        }
    }
}
