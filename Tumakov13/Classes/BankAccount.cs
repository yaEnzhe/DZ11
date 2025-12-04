using System;
using System.Collections.Generic;
using Tumakov13.Enums;

namespace Tumakov13.Classes
{
    internal class BankAccount  
    {
        private static int lastAccNum = 1;
        public int AccNum { get; }
        private decimal balance;
        public BankAcc AccType {  get; }
        private string name;
        private string surname;
        private string patronymic;
        public string FullName
        {
            get
            {
                if (patronymic!=null)
                {
                    return surname + " " + name + " " + patronymic;
                }
                else
                {
                    return surname + " " + name;
                }
            }
            set
            {
                name = value;
                surname = value;
                patronymic = value;
            }
        }
        public static List<BankTransaction> bankTransactions = new List<BankTransaction>();
        public BankTransaction this[int index]      //13.2
        {
            get
            {
                return bankTransactions[index];
            }
            set
            {
                bankTransactions[index] = value;
            }
        }
        public BankAccount(string name, string surname, string patronymic, decimal balance, BankAcc accType)
        {
            AccNum = GenerateAccNum();
            this.balance = balance;
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }
        public BankAccount(string name, string surname, decimal balance, BankAcc accType)
        {
            AccNum = GenerateAccNum();
            this.balance = balance;
            this.name = name;
            this.surname = surname;
        }

        private static int GenerateAccNum()
        {
            return lastAccNum++;
        }

        public static void AddMoney(decimal money, ref BankAccount bankAcc)
        {
            bankAcc.balance += money;
            Console.WriteLine($"Вы положили деньги на счёт {bankAcc.AccNum} \nБаланс: {bankAcc.balance} р.");
            BankTransaction bankTransaction = new BankTransaction(money);
            bankTransactions.Add(bankTransaction);
        }

        public static void GetMoney(decimal sum, ref BankAccount bankAcc)
        {
            if (sum > 0 && sum <= bankAcc.balance)
            {
                bankAcc.balance -= sum;
                Console.WriteLine($"\nВы сняли {sum} р. со счёта {bankAcc.AccNum}");
                Console.WriteLine($"Баланс: {bankAcc.balance} р.");
                BankTransaction bankTransaction = new BankTransaction(sum);
                bankTransactions.Add(bankTransaction);
            }
            else
            {
                Console.WriteLine("Недостаточно средств!");
            }
        }

        public static void TransferMoney(ref BankAccount bankAcc1, ref BankAccount bankAcc2, decimal money)
        {
            if (money > 0 && money <= bankAcc1.balance)
            {
                bankAcc1.balance = bankAcc1.balance - money;
                bankAcc2.balance = bankAcc2.balance + money;
                Console.WriteLine($"\nВы перевели {money} рублей");
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"\nНомер счета: {AccNum} \nДержатель счёта: {FullName} \nТип счёта: {AccType} \nБаланс: {balance} р.");
        }
    }
}

