using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public float PurchaseCost { get; set; }
        public int SaleCost { get; set; }
        public int Quantity { get; set; }
        public string Note { get; set; }
        public Branch Branch { get; set; }

        public Book() {}

        public Book Clone()
        {
            return new Book(No, Title, AuthorName, PurchaseCost, SaleCost, Quantity, Branch, Note);
        }

        public void Clear()
        {
            No = default;
            Title = AuthorName = Note = default;
            PurchaseCost = SaleCost = Quantity = default;
            Branch = default;

        }
        public Book(int no, string title, string authorName, float purchaseCost, int saleCost, int quantity, Branch branch, string note)
        {
            No = no;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            AuthorName = authorName ?? throw new ArgumentNullException(nameof(authorName));
            PurchaseCost = purchaseCost;
            SaleCost = saleCost;
            Quantity = quantity;
            Branch = branch ?? throw new ArgumentNullException(nameof(branch));
            Note = note;
        }
    }
}
