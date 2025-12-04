using System;

namespace Tumakov13.Classes
{
    internal class BankTransaction
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
