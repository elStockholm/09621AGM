using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _09621AGM.HW6._1;

namespace _09621AGM.HW6
{
    internal class _2
    {
        //Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы 
        //номер счета генерировался сам и был уникальным.Для этого надо создать в классе
        //статическую переменную и метод, который увеличивает значение этого переменной.
        public enum AccountType
        {
            Debit,
            Credit,
            Savings
        }

        public class BankAccount
        {
            private static long lastNumber = 0;

            private string GetTypeName(AccountType type)
            {
                switch (type)
                {
                    case AccountType.Debit:
                        return "Дебетовый";
                    case AccountType.Credit:
                        return "Кредитный";
                    case AccountType.Savings:
                        return "Сберегательный";
                    default:
                        return "Неизвестный";
                }
            }

            private long Number; 
            private decimal Balance;
            private AccountType Type;
            public BankAccount()
            { 
            }
            public BankAccount(decimal balance, AccountType type)
            {
                this.Number = GenerateNumber();
                this.Balance = balance;
                this.Type = type;
            }
            private static long GenerateNumber()
            {
                lastNumber++;
                return lastNumber;
            }
            public void SetBalance(decimal balance)
            {
                this.Balance = balance;
            }

            public void SetType(AccountType type)
            {
                this.Type = type;
            }

            public long GetNumber()
            {
                return Number;
            }

            public decimal GetBalance()
            {
                return Balance;
            }

            public AccountType GetAccountType()
            {
                return Type;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Номер счета: {Number}");
                Console.WriteLine($"Баланс: {Balance}");
                Console.WriteLine($"Тип счета: {GetTypeName(Type)}");
            }
        }

        static void Main2(string[] args)
        {
            BankAccount myAccount = new BankAccount(67228, AccountType.Credit);

            Console.WriteLine("Информация о банковском счете");
            myAccount.DisplayInfo();
        }
    }
}