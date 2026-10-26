using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW6
{
    internal class _3
    {
        //Добавить в класс счет в банке два метода: снять со счета и положить на 
        //счет.Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
        //положительного результата изменяет баланс.
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
        }

        static void Main3(string[] args)
        {
            BankAccount myAccount = new BankAccount(67228, AccountType.Credit);

            Console.WriteLine("Информация о банковском счете");
            while (true)
            {
                Console.WriteLine("\nЧто вы хотите сделать?");
                Console.WriteLine("\n1. Запросить информацию о банковском счете");
                Console.WriteLine("\n2.Снять деньги со счета");
                Console.WriteLine("\n3. Внести деньги на счет");
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
            }
        }
    }
}