using Library.Commands.Abstractions;
using Library.ViewModels;
using System;

namespace Commands.EmployeeCommands
{
    public class RejectEmployeeCMD : BaseEmployeeCommand
    {
        public RejectEmployeeCMD(EmployeeVM EmployeeVM) : base(EmployeeVM) { }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == EmployeeVM.StateEmployee)
            {
                EmployeeVM.StateEmployee = 0;
                EmployeeVM.CurrentEmployee = null;
                return;
            }
            int value = Convert.ToInt32(parameter);
            EmployeeVM.StateEmployee = value;
        }
    }
}
