using Library.Entities;
using Library.ViewModels;
using System;
using System.Linq;
using System.Windows;

namespace Commands.EmployeeCommands
{
    public class AddEmployeeCMD : BaseCommand
    {
        LibraryVM LibraryVM;

        public AddEmployeeCMD(LibraryVM LibraryVM)
        {
            this.LibraryVM = LibraryVM;
        }

        public override void Execute(object parameter)
        {
            if (Convert.ToInt32(parameter) == LibraryVM.StateEmployee)
            {
                if (LibraryVM.btnAddEmployee.Content.ToString() == "Add")
                {
                    try
                    {
                        var No = LibraryVM.Employees.Count + 1;
                        LibraryVM.Employees.Add(new Employee(No, LibraryVM.CurrentEmployee.Name, LibraryVM.CurrentEmployee.Surname,
                            LibraryVM.CurrentEmployee.PhoneNumber, LibraryVM.CurrentEmployee.Branch, 
                            LibraryVM.CurrentEmployee.Salary, LibraryVM.CurrentEmployee.Note));
                        LibraryVM.CurrentEmployee = new Employee();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Fill all fields", "Error occured while adding Employee!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    foreach (var employee in LibraryVM.Employees)
                    {
                        if (employee.No == LibraryVM.CurrentEmployee.No)
                        {
                            employee.Name = LibraryVM.CurrentEmployee.Name;
                            employee.Surname = LibraryVM.CurrentEmployee.Surname;
                            employee.PhoneNumber = LibraryVM.CurrentEmployee.PhoneNumber;
                            employee.Salary = LibraryVM.CurrentEmployee.Salary;
                            employee.Branch = LibraryVM.CurrentEmployee.Branch;
                            employee.Note = LibraryVM.CurrentEmployee.Note;
                            LibraryVM.CurrentEmployee = new Employee();
                            LibraryVM.btnAddEmployee.Content = "Add";
                            LibraryVM.StateEmployee = 0;
                            return;
                        }
                    }
                }
                LibraryVM.StateEmployee = 0;
                return;
            }
            int value = Convert.ToInt32(parameter);
            LibraryVM.StateEmployee = value;
        }
    }
}
