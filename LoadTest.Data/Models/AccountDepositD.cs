using System;

namespace LoadTest.Data.Models
{
    public class AccountDepositD
    {
        public int AccountDepositDId { get; set; }
        public int AccountDId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime DepositDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string TransactionReference { get; set; } = string.Empty;

        public virtual AccountD Account { get; set; } = null!;
    }
}
