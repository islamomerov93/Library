using Library.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book_StatusModel
    {
        public Book book { get; set; }
        public string Status { get; set; }
    }
}
