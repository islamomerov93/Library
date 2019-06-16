using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library.Commands.Abstractions
{
    public abstract class BaseUCAddingCommand : ICommand
    {
        public LibraryVM LibraryVM { get; set; }

        protected BaseUCAddingCommand(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }
}
