using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Domain.Entities
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
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
