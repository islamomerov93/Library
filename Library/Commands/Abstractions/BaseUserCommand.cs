using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library.Commands.Abstractions
{
    public abstract class BaseUserCommand : ICommand
    {
        public UserVM UserVM { get; set; }

        protected BaseUserCommand(UserVM userVM)
        {
            UserVM = userVM;
        }

        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }
}
