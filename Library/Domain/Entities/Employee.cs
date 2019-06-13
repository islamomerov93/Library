using Library.Domain.Abstractions;
using System;

namespace Library.Domain.Entities
{
    public class Employee : BaseUser
    {
        public Branch Branch { get; set; }
        public float Salary { get; set; }

        public string PhoneNumber { get; set; }

        public Employee() 
        {
        }

        public Employee Clone()
        {
            return new Employee(Id,No,Name,Surname,PhoneNumber,Branch,Salary,Note);
        }

        public Employee(int id, int no, string name, string surname, string pnoneNumber, Branch branch, float salary, string note) : base(id, no, name, surname, note)
        {
            Id = id;
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
