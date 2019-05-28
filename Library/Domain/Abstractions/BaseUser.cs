using Library.Domain.Entities;
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
        public string Note { get; set; }

        protected BaseUser()
        {
        }

        protected BaseUser(int id, int no, string name, string surname, string note)
        {
            Id = id;
            No = no;
            Name = name;
            Surname = surname;
            Note = note;
        }
    }
}
