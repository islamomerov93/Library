using Library.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class RentedBook
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime RentedTime { get; set; }
        public RentedBook()
        {

        }

        public RentedBook(int bookId, int customerId, int userId, DateTime rentedTime)
        {
            BookId = bookId;
            CustomerId = customerId;
            UserId = userId;
            RentedTime = rentedTime;
        }
        
    }
}
