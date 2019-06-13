using Library.Domain.Abstractions;
using System;

namespace Library.Domain.Entities
{
    public class Customer : BaseUser
    {
        public DateTime JoinedDate { get; set; }
        public string PhoneNumber { get; set; }

        public Customer()
        {
        }

        public Customer(int id, int no, string name, string surname, string pnoneNumber, string note, DateTime joinedDate) : base(id, no, name, surname, note)
        {
            JoinedDate = joinedDate;
        }

        public Customer Clone()
        {
            return new Customer(Id,No,Name,Surname,PhoneNumber,Note,JoinedDate);
        }
        public string Fullname
        {
            get { return Name + " " + Surname; }
        }
    }
}
