using Library.Entities;
using Library.ViewModels;
using System;
using System.Linq;
using System.Windows;

namespace Commands.EmployeeCommands
{
    public class AddEmployeeCMD : BaseCommand
    {
        EmployeeVM EmployeeVM;

        public AddEmployeeCMD(EmployeeVM EmployeeVM)
        {
            this.EmployeeVM = EmployeeVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == EmployeeVM.StateEmployee)
            {
                if (EmployeeVM.btnAddEmployee.Content.ToString() == "Add")
                {
                    try
                    {
                        var No = EmployeeVM.Employees.Count + 1;
                        EmployeeVM.Employees.Add(new Employee(EmployeeVM.CurrentEmployee.Id, No, EmployeeVM.CurrentEmployee.Name, EmployeeVM.CurrentEmployee.Surname,
                            EmployeeVM.CurrentEmployee.PhoneNumber, EmployeeVM.CurrentEmployee.Branch,
                            EmployeeVM.CurrentEmployee.Salary, EmployeeVM.CurrentEmployee.Note));
                        EmployeeVM.CurrentEmployee = new Employee();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fill all fields", "Error occured while adding Employee!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    foreach (var employee in EmployeeVM.Employees)
                    {
                        if (employee.No == EmployeeVM.CurrentEmployee.No)
                        {
                            employee.Name = EmployeeVM.CurrentEmployee.Name;
                            employee.Surname = EmployeeVM.CurrentEmployee.Surname;
                            employee.PhoneNumber = EmployeeVM.CurrentEmployee.PhoneNumber;
                            employee.Salary = EmployeeVM.CurrentEmployee.Salary;
                            employee.Branch = EmployeeVM.CurrentEmployee.Branch;
                            employee.Note = EmployeeVM.CurrentEmployee.Note;
                            EmployeeVM.CurrentEmployee = new Employee();
                            EmployeeVM.btnAddEmployee.Content = "Add";
                            EmployeeVM.StateEmployee = 0;
                            return;
                        }
                    }
                }
                EmployeeVM.StateEmployee = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            EmployeeVM.StateEmployee = value;
        }
    }
}
