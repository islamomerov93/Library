using Library.ViewModels;
using System;

namespace Commands.EmployeeCommands
{
    public class RejectEmployeeCMD : BaseCommand
    {
        EmployeeVM EmployeeVM;
        public RejectEmployeeCMD(EmployeeVM EmployeeVM)
        {
            this.EmployeeVM = EmployeeVM;
        }

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
