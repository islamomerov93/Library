using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library.Commands.Abstractions
{
    public abstract class BaseBranchCommand : ICommand
    {
        public BranchVM BranchVM { get; set; }

        protected BaseBranchCommand(BranchVM BranchVM)
        {
            this.BranchVM = BranchVM;
        }

        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }
}
