using Library.Domain.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.EmployeeCommands
{
    public class DeleteEmployeeCMD : BaseCommand
    {
        EmployeeVM EmployeeVM;

        public DeleteEmployeeCMD(EmployeeVM EmployeeVM)
        {
            this.EmployeeVM = EmployeeVM;
        }

        public override void Execute(object parameter)
        {
            int value = Convert.ToInt32(parameter);
            EmployeeVM.StateEmployee = value;
            EmployeeVM.Employees.Remove(EmployeeVM.Employees.FirstOrDefault(x=>x.No == EmployeeVM.CurrentEmployee.No));
            EmployeeVM.MyFilteredEmployees = new ObservableCollection<Employee>(EmployeeVM.Employees);
            EmployeeVM.CurrentEmployee = null;
        }
    }
}
