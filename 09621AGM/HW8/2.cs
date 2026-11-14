using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW8
{
    internal class _2
    {
        //Создать новый класс BankTransaction, который будет хранить информацию о всех банковских операциях.
        //При изменении баланса счета создается новый объект класса BankTransaction, который содержит текущую дату и время, добавленную или снятую со счета сумму.
        //Поля класса должны быть только для чтения (readonly). Конструктору класса передается один параметр – сумма.
        //В классе банковский счет добавить закрытое поле типа System.Collections.Queue, которое будет хранить объекты класса BankTransaction для данного банковского счета;
        //изменить методы снятия со счета и добавления на счет так, чтобы в них создавался объект класса BankTransaction
        //и каждый объект добавлялся в переменную типа System.Collections.Queue.
        public enum AccountType
        {
            Debit,
            Credit,
            Savings
        }
        public class BankTransaction
        {
            public readonly DateTime TransactionDate;
            public readonly decimal Amount;
            public BankTransaction(decimal amount)
            {
                this.Amount = amount;
                this.TransactionDate = DateTime.Now;
            }
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

            private Queue transactions = new Queue();

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

                    BankTransaction transaction = new BankTransaction(amount);
                    transactions.Enqueue(transaction);

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

                        BankTransaction transaction = new BankTransaction(-amount);
                        transactions.Enqueue(transaction);

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
                        fromAccount.transactions.Enqueue(new BankTransaction(-amount));

                        this.Balance += amount;
                        this.transactions.Enqueue(new BankTransaction(amount));

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
            public void DisplayTransactions()
            {
                Console.WriteLine($"\nИстория операций для счета");

                if (transactions.Count == 0)
                {
                    Console.WriteLine("Операций по данному счету пока не было.");
                }
                else
                {
                    foreach (BankTransaction transaction in transactions)
                    {
                        string operationType = transaction.Amount > 0 ? "Пополнение" : "Списание";
                        Console.WriteLine($"[{transaction.TransactionDate}] {operationType}: {Math.Abs(transaction.Amount)}");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount(67228, AccountType.Credit);
            BankAccount otherAccount = new BankAccount(67229, AccountType.Debit);

            Console.WriteLine("Информация о банковском счете");
            while (true)
            {
                Console.WriteLine("\nЧто вы хотите сделать?");
                Console.WriteLine("1. Запросить информацию о банковском счете");
                Console.WriteLine("2.Снять деньги со счета");
                Console.WriteLine("3. Внести деньги на счет");
                Console.WriteLine("4. Перевести на другой счет");
                Console.WriteLine("5. Посмотреть историю транзакций");
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
                else if (answer == "Посмотреть историю транзакций" || answer == "5")
                {
                    myAccount.DisplayTransactions();
                }
            }
        }
    }
}
