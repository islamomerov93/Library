using Library.ViewModels;
using System;

namespace Commands.EmployeeCommands
{
    public class EditEmployeeCMD : BaseCommand
    {
        LibraryVM LibraryVM;
        public EditEmployeeCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == 2)
            {
                LibraryVM.StateEmployee = 1;
                return;
            }
        }
    }
}
