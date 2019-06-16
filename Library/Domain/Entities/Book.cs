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
        [Column(TypeName = "nvarchar")]
        [StringLength(200)]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(60)]
        public string AuthorName { get; set; }
        public decimal PurchaseCost { get; set; }
        public decimal SaleCost { get; set; }
        public decimal Quantity { get; set; }
        [Column(TypeName = "text")]
        public string Note { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }

        public Book() {}

        public Book Clone()
        {
            return new Book(Id ,No, Title, AuthorName, PurchaseCost, SaleCost, Quantity, BranchId, Branch, Note);
        }

        public void Clear()
        {
            No = 0;
            Title = AuthorName = Note = null;
            PurchaseCost = SaleCost = Quantity = 0;
            Branch = null;

        }

        public Book(int id, int no, string title, string authorName, decimal purchaseCost, decimal saleCost, decimal quantity, int branchId, Branch branch, string note)
        {
            Id = id;
            No = no;
            Title = title;
            AuthorName = authorName;
            PurchaseCost = purchaseCost;
            SaleCost = saleCost;
            Quantity = quantity;
            Note = note;
            BranchId = branchId;
            Branch = branch;
        }
    }
}
