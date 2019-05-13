using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Customer : BaseUser
    {
        public DateTime JoinedDate { get; set; }

        public Customer()
        {
        }

        public Customer Clone()
        {
            return new Customer(No,Name,Surname,PhoneNumber,JoinedDate,Note);
        }
        public Customer(int no, string name, string surname, string pnoneNumber, DateTime joinedDate, string note) : base(no, name, surname, pnoneNumber,note)
        {
            No = no;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            PhoneNumber = pnoneNumber ?? throw new ArgumentNullException(nameof(pnoneNumber));
            Note = note;
            JoinedDate = joinedDate;
        }
    }
}
