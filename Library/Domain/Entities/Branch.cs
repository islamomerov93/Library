using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Branch
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }

        public Branch Clone()
        {
            return new Branch(No,Name, Address,Note);
        }
        public Branch()
        {
        }

        public Branch(int no, string name, string address, string note)
        {
            No = no;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Note = note;
        }
    }
}
