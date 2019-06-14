using Library.Commands.Abstractions;
using Library.ViewModels;
using System;

namespace Commands.EmployeeCommands
{
    public class EditEmployeeCMD : BaseEmployeeCommand
    {
        public EditEmployeeCMD(EmployeeVM EmployeeVM) : base(EmployeeVM) { }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == 2)
            {
                EmployeeVM.StateEmployee = 1;
                return;
            }
        }
    }
}
