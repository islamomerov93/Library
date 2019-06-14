using Library.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library.Commands.Abstractions
{
    public abstract class BaseEmployeeCommand : ICommand
    {
        public EmployeeVM EmployeeVM { get; set; }

        protected BaseEmployeeCommand(EmployeeVM EmployeeVM)
        {
            this.EmployeeVM = EmployeeVM;
        }

        public event EventHandler CanExecuteChanged;

        public virtual bool CanExecute(object parameter)
        {
            return true;
        }

        public abstract void Execute(object parameter);
    }
}
