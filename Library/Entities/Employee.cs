using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Employee : BaseUser
    {
        public Branch Branch { get; set; }
        public float Salary { get; set; }

        public Employee() 
        {
        }

        public Employee Clone()
        {
            return new Employee(No,Name,Surname,PhoneNumber,Branch,Salary,Note);
        }

        public Employee(int no, string name, string surname, string pnoneNumber, Branch branch, float salary, string note) : base(no, name, surname, pnoneNumber, note)
        {
            No = no;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            PhoneNumber = pnoneNumber ?? throw new ArgumentNullException(nameof(pnoneNumber));
            Branch = branch ?? throw new ArgumentNullException(nameof(branch));
            Note = note;
            Salary = salary;
        }
    }
}
