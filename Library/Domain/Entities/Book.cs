using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Domain.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [NotMapped]
        public int No { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(60)")]
        public string AuthorName { get; set; }
        public float PurchaseCost { get; set; }
        public int SaleCost { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "text")]
        public string Note { get; set; }
        public Branch Branch { get; set; }

        public Book() {}

        public Book Clone()
        {
            return new Book(No, Title, AuthorName, PurchaseCost, SaleCost, Quantity, Branch, Note);
        }

        public void Clear()
        {
            No = 0;
            Title = AuthorName = Note = null;
            PurchaseCost = SaleCost = Quantity = 0;
            Branch = null;

        }
        public Book(int no, string title, string authorName, float purchaseCost, int saleCost, int quantity, Branch branch, string note)
        {
            No = no;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            AuthorName = authorName ?? throw new ArgumentNullException(nameof(authorName));
            PurchaseCost = purchaseCost;
            SaleCost = saleCost;
            Quantity = quantity;
            Branch = branch; /*?? throw new ArgumentNullException(nameof(branch));*/
            Note = note;
        }
    }
}
