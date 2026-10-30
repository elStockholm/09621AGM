using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW6
{
    internal class LAB1
    {
        //2. Меню кафе.
        //Абстрактный «Блюдо», наследники «Суп», «Салат», «Десерт».
        //Свойства: название, цена, калорийность.
        //Методы: рассчитать стоимость порции, добавить в заказ, показать диетические отметки, пересчитать КБЖУ, сформировать чек.
        abstract class Dish
        {
            private string _name;
            private double _price;
            private double _calories;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public double Price
            {
                get { return _price; }
                set { _price = value; }
            }

            public double Calories
            {
                get { return _calories; }
                set { _calories = value; }
            }

            public Dish(string name, double price, double calories)
            {
                Name = name;
                Price = price;
                Calories = calories;
            }

            public virtual double CalculateCost(int portions)
            {
                return Price * portions;
            }

            public void AddToOrder()
            {
                Console.WriteLine($"Блюдо '{Name}' добавлено в ваш заказ.");
            }

            public abstract void ShowDietaryMarks();

            public void RecalculateMacros(double newWeight, double standardWeight)
            {
                double factor = newWeight / standardWeight;
                double newCalories = Calories * factor;
                Console.WriteLine($"Калорийность блюда '{Name}' для порции {newWeight}г составит {newCalories:F1} ккал.");
            }

            public virtual void GenerateReceipt(int portions)
            {
                Console.WriteLine($"{Name} x{portions} = {CalculateCost(portions)} руб.");
            }
        }

        class Soup : Dish
        {
            public bool IsSpicy { get; set; }

            public Soup(string name, double price, double calories, bool isSpicy)
                : base(name, price, calories)
            {
                IsSpicy = isSpicy;
            }

            public Soup() : base("Бульон куриный", 150, 120)
            {
                IsSpicy = false;
            }

            public override double CalculateCost(int portions)
            {
                double cost = base.CalculateCost(portions);
                if (IsSpicy)
                {
                    cost += 20 * portions;
                }
                return cost;
            }

            public override void ShowDietaryMarks()
            {
                if (IsSpicy)
                {
                    Console.WriteLine($"{Name}: [Острое блюдо!]");
                }
                else
                {
                    Console.WriteLine($"{Name}: [Не острое, подходит для детей]");
                }
            }

            public void HeatUp()
            {
                Console.WriteLine($"Суп '{Name}' подан горячим.");
            }
        }

        class Salad : Dish
        {
            public bool IsVegan { get; set; }

            public Salad(string name, double price, double calories, bool isVegan)
                : base(name, price, calories)
            {
                IsVegan = isVegan;
            }

            public Salad() : base("Овощной", 200, 80)
            {
                IsVegan = true;
            }

            public override void ShowDietaryMarks()
            {
                if (IsVegan)
                {
                    Console.WriteLine($"{Name}: [Веганское блюдо, без продуктов животного происхождения]");
                }
                else
                {
                    Console.WriteLine($"{Name}: [Содержит продукты животного происхождения]");
                }
            }

            public override void GenerateReceipt(int portions)
            {
                Console.WriteLine($"Салат: {Name} x{portions} = {CalculateCost(portions)} руб.");
            }

            public void AddDressing()
            {
                Console.WriteLine($"К салату '{Name}' добавлена фирменная заправка.");
            }
        }

        class Dessert : Dish
        {
            public bool ContainsGluten { get; set; }

            public Dessert(string name, double price, double calories, bool containsGluten)
                : base(name, price, calories)
            {
                ContainsGluten = containsGluten;
            }

            public Dessert() : base("Фруктовая тарелка", 350, 150)
            {
                ContainsGluten = false;
            }

            public override void ShowDietaryMarks()
            {
                if (ContainsGluten)
                {
                    Console.WriteLine($"{Name}: [Содержит глютен]");
                }
                else
                {
                    Console.WriteLine($"{Name}: [Без глютена]");
                }
            }

            public void AddCandles(int count)
            {
                Console.WriteLine($"В десерт '{Name}' добавлено свечей: {count} шт.");
            }

            public void PackToTakeAway()
            {
                Console.WriteLine($"Десерт '{Name}' упакован в контейнер с собой.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в кафе");
            Console.WriteLine("-----------------------");

            Soup borscht = new Soup("Борщ Фирменный", 350, 400, false);
            Soup tomYum = new Soup("Том Ям с морепродуктами", 550, 320, true);

            Salad caesar = new Salad("Цезарь с креветками", 480, 520, false);
            Salad greek = new Salad("Греческий салат", 320, 250, true);

            Dessert cheesecake = new Dessert("Чизкейк Нью-Йорк", 280, 450, true);
            Dessert fruits = new Dessert();

            Dish[] menu = { borscht, tomYum, caesar, greek, cheesecake, fruits };

            Console.WriteLine("Наше меню на сегодня:\n");
            foreach (Dish item in menu)
            {
                Console.WriteLine($"-{item.Name} ({item.Price} руб.)");
                item.ShowDietaryMarks();
            }

            Console.WriteLine("\n--------------------");
            Console.WriteLine("Формирование вашего заказа...");

            borscht.AddToOrder();
            caesar.AddToOrder();
            cheesecake.AddToOrder();

            Console.WriteLine("\nПодготовка блюд:");
            borscht.HeatUp();
            caesar.AddDressing();
            cheesecake.AddCandles(1);

            Console.WriteLine("\nСправка по калорийности:");
            caesar.RecalculateMacros(500, 250);

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("Ваш чек:");

            borscht.GenerateReceipt(1);
            caesar.GenerateReceipt(2);
            cheesecake.GenerateReceipt(1);

            double totalCost = borscht.CalculateCost(1) + caesar.CalculateCost(2) + cheesecake.CalculateCost(1);
            Console.WriteLine($"\nИтого к оплате: {totalCost} руб.");
            Console.WriteLine("Спасибо, что выбрали наше кафе!");

            Console.ReadLine();
        }
    }
}