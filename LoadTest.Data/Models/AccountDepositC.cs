using System;

namespace LoadTest.Data.Models
{
    public class AccountDepositC
    {
        public int AccountDepositCId { get; set; }
        public int AccountCId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime DepositDate { get; set; }
        public DateTime InsertDate { get; set; }
        public string TransactionReference { get; set; } = string.Empty;

        public virtual AccountC Account { get; set; } = null!;
    }
}
