using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public abstract class BaseUser
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PnoneNumber { get; set; }
        public string Note { get; set; }

        protected BaseUser()
        {
        }

        protected BaseUser(int no, string name, string surname, string pnoneNumber, string note)
        {
            No = no;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            PnoneNumber = pnoneNumber ?? throw new ArgumentNullException(nameof(pnoneNumber));
            Note = note;
        }
    }
}
