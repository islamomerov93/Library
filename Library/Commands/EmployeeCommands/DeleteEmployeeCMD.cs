using Library.Commands.Abstractions;
using Library.Domain.Entities;
using Library.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Commands.EmployeeCommands
{
    public class DeleteEmployeeCMD : BaseEmployeeCommand
    {
        public DeleteEmployeeCMD(EmployeeVM EmployeeVM) : base(EmployeeVM) { }

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
