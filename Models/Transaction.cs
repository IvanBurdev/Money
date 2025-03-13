using System.ComponentModel.DataAnnotations;

namespace Money.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //CategoryID
    }
}
