using Library.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class SoldBook
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime SoldTime { get; set; }
        public SoldBook()
        {

        }

        public SoldBook(int bookId, int customerId, int userId, DateTime soldTime)
        {
            BookId = bookId;
            CustomerId = customerId;
            UserId = userId;
            SoldTime = soldTime;
        }
    }
}
