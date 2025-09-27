using System;

namespace LoadTest.Data.Models
{
    public class AccountWithdrawD
    {
        public int AccountWithdrawDId { get; set; }
        public int AccountDId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime WithdrawDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string TransactionReference { get; set; } = string.Empty;

        public virtual AccountD Account { get; set; } = null!;
    }
}
