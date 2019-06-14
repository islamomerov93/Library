using Library.Domain;
using Library.Domain.Abstractions;
using Library.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Library.DataAccess.EF_CodeFirst.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        LibraryDBContext context;
        
        public List<Employee> GetAll()
        {
            List<Employee> employees;
            using (context = new LibraryDBContext())
            {
                employees = new List<Employee>(context.Employees.Include("Branch"));
            }
            return employees;
        }

        public Employee GetById(int id)
        {
            Employee worker;
            using (context = new LibraryDBContext())
            {
                worker = context.Employees.AsQueryable().FirstOrDefault(x => x.Id == id).Clone();
            }
            return worker;
        }

        public void Add(Employee employee)
        {
            using (context = new LibraryDBContext())
            {
                if (employee.Id == 0)
                {
                    context.Employees.Add(employee);
                    context.SaveChanges();
                }
                else
                {
                    Employee newEmployee = context.Employees.FirstOrDefault(x => x.Id == employee.Id);
                    newEmployee.Name = employee.Name;
                    newEmployee.Surname = employee.Surname;
                    newEmployee.Branch = employee.Branch;
                    newEmployee.Salary = employee.Salary;
                    newEmployee.PhoneNumber = employee.PhoneNumber;
                    newEmployee.Note = employee.Note;
                    context.SaveChanges();
                }
            }
        }

        public void Remove(Employee employee)
        {
            using (context = new LibraryDBContext())
            {
                Employee newEmployee = context.Employees.FirstOrDefault(x => x.Id == employee.Id);
                context.Employees.Remove(newEmployee);
                context.SaveChanges();
            }
        }
    }
}
