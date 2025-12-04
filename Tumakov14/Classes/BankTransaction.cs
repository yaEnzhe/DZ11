using System;

namespace Tumakov14.Classes
{
    public class BankTransaction
    {
        public decimal Money { get; }
        public DateTime DateTime { get; }
        public BankTransaction(decimal money)
        {
            DateTime = DateTime.Now;
            Money = money;
        }
    }
}
