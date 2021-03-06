﻿using Library.Commands.Abstractions;
using Library.Domain.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.BranchCommands
{
    public class DeleteBranchCMD : BaseBranchCommand
    {
        public DeleteBranchCMD(BranchVM BranchVM) : base(BranchVM) { }

        public override void Execute(object parameter)
        {
            int value = Convert.ToInt32(parameter);
            BranchVM.StateBranch = value;
            BranchVM.Branches.Remove(BranchVM.Branches.FirstOrDefault(x => x.No == BranchVM.CurrentBranch.No));
            BranchVM.MyFilteredBranches = new ObservableCollection<Branch>(BranchVM.Branches);
            BranchVM.CurrentBranch = null;
        }
    }
}
