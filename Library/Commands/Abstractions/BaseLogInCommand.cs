using Library.ViewModels;
using System;
using System.Windows.Input;

namespace Library.Commands.Abstractions
{
    public abstract class BaseLogInCommand : ICommand
    {
        public LogInVM LogInVM { get; set; }

        protected BaseLogInCommand(LogInVM LogInVM)
        {
            this.LogInVM = LogInVM;
        }

        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }
}
