using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities
{
    public class Permissions
    {
        public bool CanAddBook { get; set; }
        public bool CanAddUser { get; set; }
        public bool CanAddBranch { get; set; }
        public bool CanAddCustomer { get; set; }
        public bool CanAddEmployee { get; set; }
        public bool CanRentSale { get; set; }
    }
}
