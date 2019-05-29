using Library.ViewModels;
using System;

namespace Commands.EmployeeCommands
{
    public class EditEmployeeCMD : BaseCommand
    {
        EmployeeVM EmployeeVM;
        public EditEmployeeCMD(EmployeeVM EmployeeVM)
        {
            this.EmployeeVM = EmployeeVM;
        }

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
