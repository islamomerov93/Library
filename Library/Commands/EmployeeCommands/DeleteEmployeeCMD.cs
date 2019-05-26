using Library.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.EmployeeCommands
{
    public class DeleteEmployeeCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public DeleteEmployeeCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateEmployee = value;
            LibraryVM.Employees.Remove(LibraryVM.Employees.FirstOrDefault(x=>x.No == LibraryVM.CurrentEmployee.No));
            LibraryVM.MyFilteredEmployees = new ObservableCollection<Employee>(LibraryVM.Employees);
            LibraryVM.CurrentEmployee = null;
        }
    }
}
