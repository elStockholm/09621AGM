using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW8
{
    internal class _1
    {
        //В классе банковский счет, созданном в предыдущих упражнениях, удалить методы заполнения полей.
        //Вместо этих методов создать конструкторы. Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс,
        //конструктор для заполнения поля тип банковского счета, конструктор для заполнения баланса и типа банковского счета.
        //Каждый конструктор должен вызывать метод, генерирующий номер счета.

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
                this.Number = GenerateNumber();
            }
            public BankAccount(decimal balance)
            {
                this.Number = GenerateNumber();
                this.Balance = balance;
            }
            public BankAccount(AccountType type)
            {
                this.Number = GenerateNumber();
                this.Type = type;
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
            public void Deposit(decimal amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine("Успешно");
                }
                else
                {
                    Console.WriteLine("Сумма для пополнения должна быть больше нуля.");
                }
            }
            public void AntiDeposit(decimal amount)
            {
                if (amount > 0)
                {
                    if (amount <= Balance)
                    {
                        Balance -= amount;
                        Console.WriteLine("Успешно");
                    }
                    else
                    {
                        Console.WriteLine("Не удалось снять");
                    }
                }
                else
                {
                    Console.WriteLine("Сумма для снятия должна быть больше нуля.");
                }
            }
            public void Transfer(BankAccount fromAccount, decimal amount)
            {
                if (amount > 0)
                {
                    if (fromAccount.Balance >= amount)
                    {
                        fromAccount.Balance -= amount;
                        this.Balance += amount;
                        Console.WriteLine("Успешно");
                    }
                    else
                    {
                        Console.WriteLine("Не удалось снять");
                    }
                }
                else
                {
                    Console.WriteLine("Сумма для перевода должна быть больше нуля.");
                }
            }
        }

        static void Main1(string[] args)
        {
            BankAccount myAccount = new BankAccount(67228, AccountType.Credit);
            BankAccount otherAccount = new BankAccount(67229, AccountType.Debit);

            Console.WriteLine("Информация о банковском счете");
            while (true)
            {
                Console.WriteLine("\nЧто вы хотите сделать?");
                Console.WriteLine("\n1. Запросить информацию о банковском счете");
                Console.WriteLine("\n2.Снять деньги со счета");
                Console.WriteLine("\n3. Внести деньги на счет");
                Console.WriteLine("\n4. Перевести на другой счет");
                string answer = Console.ReadLine();
                if (answer == "Запросить информацию о банковском счете" || answer == "1")
                {
                    myAccount.DisplayInfo();
                }
                if (answer == "Снять деньги со счета" || answer == "2")
                {
                    Console.WriteLine("\nСколько вы хотите снять");
                    decimal antideposit = decimal.Parse(Console.ReadLine());
                    myAccount.AntiDeposit(antideposit);
                }
                if (answer == "Внести деньги на счет" || answer == "3")
                {
                    Console.WriteLine("\nСколько вы хотите внести");
                    decimal deposit = decimal.Parse(Console.ReadLine());
                    myAccount.Deposit(deposit);
                }
                if (answer == "Перевести на другой счет" || answer == "4")
                {
                    Console.WriteLine("\nСколько вы хотите перевести со второго счета на текущий?");
                    decimal transferAmount = decimal.Parse(Console.ReadLine());
                    myAccount.Transfer(otherAccount, transferAmount);
                }
            }
        }
    }
}
