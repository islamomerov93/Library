using Library.ViewModels;
using System;

namespace Commands.EmployeeCommands
{
    public class RejectEmployeeCMD : BaseCommand
    {
        LibraryVM LibraryVM;
        public RejectEmployeeCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == LibraryVM.StateEmployee)
            {
                LibraryVM.StateEmployee = 0;
                LibraryVM.CurrentEmployee = null;
                return;
            }
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateEmployee = value;
        }
    }
}
