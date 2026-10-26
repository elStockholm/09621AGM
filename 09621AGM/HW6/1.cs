using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _09621AGM.HW6._1;

namespace _09621AGM.HW6
{
    internal class _1
    {
        //Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип 
        //банковского счета(использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
        //доступа к данным – заполнения и чтения.Создать объект класса, заполнить его поля и
        //вывести информацию об объекте класса на печать.
        public enum AccountType
        {
            Debit,
            Credit,
            Savings
        }
        public class BankAccount
        {
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
            private string Number;
            private decimal Balance;
            private AccountType Type;
            public BankAccount()
            {
            }
            public BankAccount(string number, decimal balance, AccountType type)
            {
                Number = number;
                Balance = balance;
                Type = type;
            }
            public void SetNumber(string number)
            {
                this.Number = number;
            }
            public void SetBalance(decimal balance)
            {
                this.Balance = balance;
            }
            public void SetType(AccountType type)
            {
                this.Type = type;
            }
            public string GetNumber()
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
        static void Main1(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            myAccount.SetNumber("67");
            myAccount.SetBalance(67228);
            myAccount.SetType(AccountType.Credit);

            Console.WriteLine("Информация о банковском счете");
            myAccount.DisplayInfo();
        }
    }
}