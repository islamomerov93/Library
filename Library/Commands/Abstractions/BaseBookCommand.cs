using Library.ViewModels;
using System;
using System.Windows.Input;

namespace Library.Commands.Abstractions
{
    public abstract class BaseBookCommand : ICommand
    {
        public BookVM BookVM { get; set; }

        protected BaseBookCommand(BookVM bookVM)
        {
            BookVM = bookVM;
        }

        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }
}
